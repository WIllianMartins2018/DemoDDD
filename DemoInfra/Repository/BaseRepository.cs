using DemoDomain.Entities;
using DemoDomain.Interfaces;
using DemoInfra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoInfra.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DemoContext _context;

        public BaseRepository(DemoContext context)
        {
            _context = context;
        }

        public void Insert(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Set<TEntity>().Remove(Select(id));
            _context.SaveChanges();
        }

        public IList<TEntity> Select() =>
            _context.Set<TEntity>().ToList();

        public TEntity Select(int id) =>
            _context.Set<TEntity>().Find(id);

    }
}
