using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces.DAL
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity GetById(object id);
        IEnumerable<TEntity> GetAll();
        void Insert(TEntity entity);
        void Delete(object id);
        void Delete(TEntity entityToDelete);
        void Update(TEntity entityToUpdate);
    }
}
