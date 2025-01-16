using Microsoft.AspNetCore.Mvc;
using Ch02Ex1FutureValue.Models;

namespace Ch02Ex1FutureValue.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Fv = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            ViewBag.FV = model.CalculateFutureValue();
            return View(model);
        }
    }
}
