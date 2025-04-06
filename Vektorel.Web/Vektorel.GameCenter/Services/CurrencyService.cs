using Microsoft.Extensions.Caching.Memory;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Vektorel.GameCenter.Services
{
    public class CurrencyService
    {
        private readonly HttpClient httpClient;
        private readonly IMemoryCache memoryCache;

        public CurrencyService(IHttpClientFactory httpClientFactory, IMemoryCache memoryCache) 
        {
            this.httpClient = httpClientFactory.CreateClient(nameof(CurrencyService));
            this.memoryCache = memoryCache;
        }

        public decimal GetLatestCurrencies()
        {
            //cache içinde aradığım değer varsa direkt onu dön
            if (memoryCache.TryGetValue<decimal>(nameof(Currency), out var cachedCurrency))
            {
                return cachedCurrency;
            }

            var fiveDaysAgo = DateTime.Now.AddDays(-5).ToString("dd-MM-yyyy");
            var now = DateTime.Now.ToString("dd-MM-yyyy");
            var response = httpClient.GetAsync($"service/evds/series=TP.DK.USD.A&startDate={fiveDaysAgo}&endDate={now}&type=json&aggregationTypes=sum&formulas=0&frequency=1")
                                   .GetAwaiter()
                                   .GetResult();

            if (!response.IsSuccessStatusCode)
            {
                //Ya da alternatif sorgu veya kayıtlı değer
                return 0;
            }

            var content = response.Content.ReadAsStringAsync()
                                        .GetAwaiter()
                                        .GetResult();
            var summary = JsonSerializer.Deserialize<TcmbResult>(content);
            if (summary.TotalCount > 0)
            {
                var currency = summary.Items
                                      .Where(f => f.HasValue)
                                      .OrderByDescending(o => o.TimeStamp)
                                      .First();
                var value = decimal.Parse(currency.Value, CultureInfo.InvariantCulture);
                memoryCache.Set(nameof(Currency), value, DateTimeOffset.Now.AddSeconds(15));
                return value;
            }
            return 0;

            //2.500.000,24
            //2500000,24
            //"2,500,000.34"
            //2025-04-15
            //12-03-2025
        }


        public class Currency
        {
            [JsonPropertyName("Tarih")]
            public string Date { get; set; }

            [JsonPropertyName("TP_DK_USD_A")]
            public string Value { get; set; }

            [JsonPropertyName("UNIXTIME")]
            public TimeStampResult TimeStamp { get; set; }

            public bool HasValue => !string.IsNullOrEmpty(Value);
        }

        public class TcmbResult
        {
            [JsonPropertyName("totalCount")]
            public int TotalCount { get; set; }

            [JsonPropertyName("items")]
            public List<Currency> Items { get; set; }
        }

        public class TimeStampResult : IComparable
        {
            [JsonPropertyName("$numberLong")]
            public string NumberLong { get; set; }

            public int CompareTo(object obj)
            {
                return int.Parse(NumberLong);
            }
        }
    }
}
