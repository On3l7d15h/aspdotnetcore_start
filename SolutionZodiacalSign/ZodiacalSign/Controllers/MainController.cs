using Microsoft.AspNetCore.Mvc;
//added
using Application.ViewModel;
using Application.Service;

namespace ZodiacalSign.Controllers
{
    public class MainController : Controller
    {
        private readonly EstimateZodiacalService _zodiacalService;
        public MainController()
        {
            _zodiacalService = new();   
        }

        public IActionResult Index()
        {
            return View(_zodiacalService.GetZodiacalSign());
        }

        [HttpPost]
        public IActionResult Index(EstimateZodiacalSignViewModel zodiacalData)
        {
            _zodiacalService.Add(zodiacalData);
            return RedirectToRoute(new {Controller="Main", Action="Index"});
        }
    }
}
