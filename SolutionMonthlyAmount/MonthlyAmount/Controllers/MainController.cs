using Microsoft.AspNetCore.Mvc;
//added
using Application.Service;
using Application.ViewModel;

namespace MonthlyAmount.Controllers
{
    public class MainController : Controller
    {
        private readonly DataLendingService _dataLending;
        
        public MainController()
        {
            _dataLending = new();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(DataLendingViewModel dvm)
        {
            _dataLending.CalculateMount(dvm);
            return View(_dataLending.GetResults());
        }
    }
}
