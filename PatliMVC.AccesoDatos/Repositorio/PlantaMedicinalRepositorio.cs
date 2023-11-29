using PatliMVC.AccesoDatos.Data;
using PatliMVC.AccesoDatos.Repositorio.IRepositorio;
using PatliMVC.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatliMVC.AccesoDatos.Repositorio
{
    internal class PlantaMedicinalRepositorio:Repositorio<PlantaMedicinal>, IPlantaMedicinalRepositorio
    {
        private readonly ApplicationDbContext _db;
        public PlantaMedicinalRepositorio(ApplicationDbContext db):base(db)
        {
            _db = db;
        }

        public void Actualizar(PlantaMedicinal plantaMedicinal)
        {
            var plantaMedicinalDB = _db.PlantasMedicinales.FirstOrDefault(s => s.ID == plantaMedicinal.ID);
            if(plantaMedicinalDB!=null)
            {
                plantaMedicinalDB.NombreComun = plantaMedicinal.NombreComun;
                plantaMedicinalDB.NombreCientifico = plantaMedicinal.NombreCientifico;
                plantaMedicinalDB.NombreNahuatl = plantaMedicinal.NombreNahuatl;
                plantaMedicinalDB.Descripcion = plantaMedicinal.Descripcion;
                plantaMedicinalDB.UsoMedicinal = plantaMedicinal.UsoMedicinal;
                plantaMedicinalDB.Contraindicaciones = plantaMedicinal.Contraindicaciones;
                plantaMedicinalDB.EvaluacionCientifica = plantaMedicinal.EvaluacionCientifica;
                plantaMedicinalDB.Imagen = plantaMedicinal.Imagen;
                plantaMedicinalDB.Aprobado = plantaMedicinal.Aprobado;
                _db.SaveChanges();
            }
        }
    }
    
}
