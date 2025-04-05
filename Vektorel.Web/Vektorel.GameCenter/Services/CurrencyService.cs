namespace Vektorel.GameCenter.Services
{
    public class CurrencyService
    {
        private readonly HttpClient httpClient;

        public CurrencyService(IHttpClientFactory httpClientFactory) 
        {
            this.httpClient = httpClientFactory.CreateClient(nameof(CurrencyService));
        }

        public List<decimal> GetLatestCurrencies()
        {
            var result = httpClient.GetAsync("service/evds/series=TP.DK.USD.S.YTL&startDate=01-04-2025&endDate=04-04-2025&type=json&aggregationTypes=avg&formulas=1&frequency=8")
                                   .GetAwaiter()
                                   .GetResult();

            var content = result.Content.ReadAsStringAsync()
                                        .GetAwaiter()
                                        .GetResult();
            return null;
        }
    }
}
