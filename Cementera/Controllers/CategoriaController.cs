using Microsoft.AspNetCore.Mvc;
using Modelos;

namespace Cementera.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly CementeraDBContext _db;

        public CategoriaController(CementeraDBContext db)
        {
           _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Categoria> categorias = _db.Categoria;
            return View(categorias);
        }
    }
}
