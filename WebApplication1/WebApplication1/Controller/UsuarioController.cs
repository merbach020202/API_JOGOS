using Microsoft.AspNetCore.Mvc;

namespace senai.inlock.webApi.Controller
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
