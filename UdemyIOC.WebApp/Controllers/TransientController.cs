using Microsoft.AspNetCore.Mvc;
using UdemyIOC.WebApp.Models;

namespace UdemyIOC.WebApp.Controllers
{
    public class TransientController : Controller
    {
        private readonly ITransientDateService _transientDateService;
        public TransientController(ITransientDateService transientDateService)
        {
            _transientDateService = transientDateService;
        }

        public IActionResult Index([FromServices] ITransientDateService transientDateService2)
        {
            ViewBag.time1 = _transientDateService.GetDateTime.TimeOfDay.ToString();
            ViewBag.time2 = transientDateService2.GetDateTime.TimeOfDay.ToString();
            return View();
        }
    }
}