using PatliMVC.AccesoDatos.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatliMVC.AccesoDatos.Repositorio.IRepositorio
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        private readonly ApplicationDbContext _db;
        public IPlantaMedicinalRepositorio PlantaMedicinal { get; private set; }

        public UnidadTrabajo(ApplicationDbContext db)
        {
            _db = db;
            PlantaMedicinal = new PlantaMedicinalRepositorio(_db);
        }
      
        public void Dispose()
        {
            _db.Dispose();
        }

        public async Task Guardar()
        {
            await _db.SaveChangesAsync();
        }
    }
}
