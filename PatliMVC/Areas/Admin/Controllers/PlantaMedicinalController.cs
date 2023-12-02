using Microsoft.AspNetCore.Mvc;
using PatliMVC.AccesoDatos.Repositorio.IRepositorio;

namespace PatliMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PlantaMedicinalController : Controller
    {
        private readonly IUnidadTrabajo _unidadTrabajo;

        public PlantaMedicinalController(IUnidadTrabajo unidadTrabajo)
        {
            _unidadTrabajo = unidadTrabajo;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region API
        [HttpGet]
        public async Task<IActionResult> ObtenerTodos()
        {
            var todos = Json(new { data = await _unidadTrabajo.PlantaMedicinal.ObtenerTodosAsync() });
            return todos;
        }
        #endregion
    }
}
