using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PatliMVC.AccesoDatos.Repositorio.IRepositorio
{
    public interface IRepositorio<T> where T : class
    {
        Task<T> ObtenerAsync(int id);
        Task<IEnumerable<T>> ObtenerTodosAsync(
            Expression<Func<T, bool>> filtro = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> ordenarPor = null,
            string propiedades = null,
            bool isTracking = true
        );
        Task<T> ObtenerPrimeroAsync(
            Expression<Func<T, bool>> filtro = null,
            string propiedades = null,
            bool isTracking = true
        );
        Task Agregar(T entidad);
        void Remover(int id);
        void Remover(T entidad);
        void RemoverRango(IEnumerable<T> entidad);
    }
}
