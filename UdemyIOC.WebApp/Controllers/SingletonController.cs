using Microsoft.AspNetCore.Mvc;
using UdemyIOC.WebApp.Models;

namespace UdemyIOC.WebApp.Controllers
{
    public class SingletonController : Controller
    {
        private readonly ISingletonDateService _singletonDateService2;
        public SingletonController(ISingletonDateService singletonDateService)
        {
            _singletonDateService2 = singletonDateService;
        }

        public IActionResult Index([FromServices] ISingletonDateService singletonDateService2)
        {
            ViewBag.time1 = _singletonDateService2.GetDateTime.TimeOfDay.ToString();
            ViewBag.time2 = singletonDateService2.GetDateTime.TimeOfDay.ToString();
            return View();
        }
    }
}