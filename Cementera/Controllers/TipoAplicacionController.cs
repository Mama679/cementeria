using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace Cementera.Controllers
{
    public class TipoAplicacionController : Controller
    {
        private readonly CementeraDBContext _db;

        public TipoAplicacionController(CementeraDBContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<TipoAplicacion> lista = _db.TipoAplicacion;
            return View(lista);
        }

        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(TipoAplicacion tipo)
        {
            _db.TipoAplicacion.Add(tipo);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
