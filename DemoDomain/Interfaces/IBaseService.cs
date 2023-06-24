using DemoDomain.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDomain.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : BaseEntity
    {
        TEntity Add<TValidator> (TEntity entity) where TValidator : AbstractValidator<TEntity>;
        void Delete(int id);
        IList<TEntity> GetAll();
        TEntity GetById(int id);
        TEntity Update<TValidator>(TEntity entity) where TValidator : AbstractValidator<TEntity>;
    }
}
