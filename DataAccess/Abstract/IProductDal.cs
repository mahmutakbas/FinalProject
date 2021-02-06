using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    //Dal : Data Access Lear
    //Dao : Data Access Object
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
//Core Refactoring: kodun iğleştirilmesi kodlarımızı bir yerde yükleyip tekrarı önlüyoruz.