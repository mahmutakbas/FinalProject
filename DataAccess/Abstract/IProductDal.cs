using Entities.Concrete;
using System.Collections.Generic;

namespace DataAccess.Abstract
{
    //Dal : Data Access Lear
    //Dao : Data Access Object
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
