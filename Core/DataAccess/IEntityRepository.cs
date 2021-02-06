using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

//Namespace : 
//Core katmanını bütün projelerimizde kullanabiliz
//Bu katmanı bir çok projemizde tekrarı önlemek için yapıyoruz
//Core katmanı diğer katmanları referans almaz
namespace Core.DataAccess
{
    //generic constraint : generic kısıt
    //class : referans tip
    //IEntity : IEntity olabilir veya IEntity implemente eden bir nesne olabilir
    //new() : new'lenebiliri olmalı
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        //Manuel filtreleme yapmak için kullanacağımız Expression Delege yapısı 
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
