using Microsoft.AspNetCore.Mvc;

namespace Cementera.Controllers
{
    public class TipoAplicacionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
