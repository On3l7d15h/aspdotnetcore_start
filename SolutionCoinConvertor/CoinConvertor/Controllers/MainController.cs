using Microsoft.AspNetCore.Mvc;
//added
using Application.ViewModel;
using Application.Service;

namespace CoinConvertor.Controllers
{
    public class MainController : Controller
    {
        private readonly CoinsDataService _dataService;

        public MainController()
        {
            _dataService = new();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CoinsDataViewModel cdm)
        {
            _dataService.MakeConvertion(cdm);
            return View(_dataService.GetData());
        }
    }
}
