﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic Constraint
    //class : referans tip
    //IEntity : IEntity veya IEntity implement eden bir tip olabilir
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        //Standart
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
