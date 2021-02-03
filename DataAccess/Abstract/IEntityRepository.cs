using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    //generic constraint : generic kısıt
    //class : referans tip
    //IEntşty : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : new'lenebiliri olmalı
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        //Manuel filtreleme yapmak için kullanacağımız Expression Delege yapısı 
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
