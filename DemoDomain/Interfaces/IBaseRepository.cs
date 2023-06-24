using DemoDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDomain.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(int id);
        IList<TEntity> Select();
        TEntity Select(int id);
    }
}
