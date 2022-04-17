﻿using ProvisionSecond.Core.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProvisionSecond.Business.Repository.Abstracts
{
    public interface IRepository<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        TEntity GetById(TKey id);
        TKey Insert(TEntity entity, bool isSaveLater = false);
        int Update(TEntity entity, bool isSaveLater = false);
        int Delete(TKey id, bool isSaveLater = false);
        int Save();
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> predicate = null);
    }
}
