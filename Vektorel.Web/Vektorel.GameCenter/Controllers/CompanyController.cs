using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vektorel.GameCenter.Data;
using Vektorel.GameCenter.Models;
using Vektorel.GameCenter.Services;

namespace Vektorel.GameCenter.Controllers;

[Authorize]
public class CompaniesController : Controller
{
    private readonly GameCenterContext context;
    private readonly CurrencyService currencyService;

    public CompaniesController(GameCenterContext context, CurrencyService currencyService)
    {
        this.context = context;
        this.currencyService = currencyService;
    }
    public IActionResult Index()
    {
        var vm = new CompanyViewModel();
        vm.Companies = context.Companies
                              .Select(s => new CompanyListDto
                              {
                                  Name = s.Name,
                                  Country = s.Country.Name
                              })
                              .ToList();
        vm.Currency= currencyService.GetLatestCurrencies();
        return View(vm);
    }
}
