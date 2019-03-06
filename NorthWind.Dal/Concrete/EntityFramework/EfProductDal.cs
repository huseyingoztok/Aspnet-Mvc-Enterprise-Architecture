using NorthWind.Dal.Abstract;
using NorthWind.Entities;
using NorthWind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Dal.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthWindContext>, IProductDal
    {
        
    }
}
