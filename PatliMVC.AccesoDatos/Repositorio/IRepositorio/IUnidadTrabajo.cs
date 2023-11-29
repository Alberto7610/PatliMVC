using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatliMVC.AccesoDatos.Repositorio.IRepositorio
{
    public interface IUnidadTrabajo:IDisposable
    {
        IPlantaMedicinalRepositorio PlantaMedicinal { get; }
        Task Guardar();
    }
}
