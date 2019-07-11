using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository
{
    public interface IRepository<TEntity>
    {
        List<TEntity> GetAll();
        TEntity GetById(params object[] id);
        TEntity Add(TEntity entity);
        bool Update(TEntity entity);
        bool Remove(TEntity entity);

    }
}