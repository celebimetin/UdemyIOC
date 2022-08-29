using Microsoft.AspNetCore.Mvc;
using UdemyIOC.WebApp.Models;

namespace UdemyIOC.WebApp.Controllers
{
    public class ScopedController : Controller
    {
        private readonly IScopedDateService _scopedDateService;
        public ScopedController(IScopedDateService scopedDateService)
        {
            _scopedDateService = scopedDateService;
        }

        public IActionResult Index([FromServices] IScopedDateService scopedDateService2)
        {
            ViewBag.time1 = _scopedDateService.GetDateTime.TimeOfDay.ToString();
            ViewBag.time2 = scopedDateService2.GetDateTime.TimeOfDay.ToString();
            return View();
        }
    }
}