using Microsoft.EntityFrameworkCore;
using PatliMVC.AccesoDatos.Data;
using PatliMVC.AccesoDatos.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PatliMVC.AccesoDatos.Repositorio
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {

        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repositorio(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
        }
        public async Task Agregar(T entidad)
        {
            await dbSet.AddAsync(entidad); //insert into tabla
        }

        public async Task<T> ObtenerAsync(int id)
        {
            return await dbSet.FindAsync(id); // select * from (solo por Id)
        }

        public async Task<IEnumerable<T>> ObtenerTodosAsync(Expression<Func<T, bool>> filtro = null, 
            Func<IQueryable<T>, IOrderedQueryable<T>> ordenarPor = null, string incluirPropiedades = null, bool isTracking = true)
        {
            IQueryable<T> query = dbSet;
            if (filtro != null)
            {
                query = query.Where(filtro); //select * from tabla where filtro
            }
            if(incluirPropiedades!=null)
            {
                foreach (var incluirProp in incluirPropiedades.Split(new char[] {','},StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(incluirProp); // Ejmeplo "Usos Medicinales y Propiedades Medicinales"
                }
            }
            if(ordenarPor!=null)
            {
                query = ordenarPor(query); //select * from tabla where filtro order by ordenarPor
            }   
            if(!isTracking)
            {
                query = query.AsNoTracking(); //select * from tabla where filtro order by ordenarPor
            }
            return await query.ToListAsync();
        }

        public async Task<T> ObtenerPrimeroAsync(Expression<Func<T, bool>> filtro = null, string incluirPropiedades = null, bool isTracking = true)
        {
            {
                IQueryable<T> query = dbSet;
                if (filtro != null)
                {
                    query = query.Where(filtro); //select * from tabla where filtro
                }
                if (incluirPropiedades != null)
                {
                    foreach (var incluirProp in incluirPropiedades.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        query = query.Include(incluirProp); // Ejmeplo "Usos Medicinales y Propiedades Medicinales"
                    }
                }
                
                if (!isTracking)
                {
                    query = query.AsNoTracking(); //select * from tabla where filtro order by ordenarPor    
                }
                return await query.FirstOrDefaultAsync();
            }
        }

       

        public void Remover(int id)
        {
            dbSet.Remove(dbSet.Find(id)); //delete from tabla where id = id
        }

        public void Remover(T entidad)
        {
            dbSet.Remove(entidad); //delete from tabla where id = entidad.id
        }

        public void RemoverRango(IEnumerable<T> entidad)
        {
            dbSet.RemoveRange(entidad); //delete from tabla where id = entidad.id
        }
    }
}
