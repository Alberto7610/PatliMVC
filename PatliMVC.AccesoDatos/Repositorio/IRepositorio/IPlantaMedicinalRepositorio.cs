using PatliMVC.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatliMVC.AccesoDatos.Repositorio.IRepositorio
{
    public interface IPlantaMedicinalRepositorio:IRepositorio<PlantaMedicinal>
    {
        void Actualizar(PlantaMedicinal plantaMedicinal);
    }
}
