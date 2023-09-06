using Microsoft.AspNetCore.Mvc;

namespace senai.inlock.webApi.Controller
{
    public class JogosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
