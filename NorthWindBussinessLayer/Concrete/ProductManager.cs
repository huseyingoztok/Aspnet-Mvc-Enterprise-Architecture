using NorthWind.Dal.Abstract;
using NorthWind.Entities.Concrete;
using NorthWind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthWindBussinessLayer.Concrete
{
    /*
     * IProductService kullanma nedenimiz hem Bussiness Layer hem de servis katmanı bu temel katmanı kullanması
     */
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            this._productDal = productDal;
        }


        public List<Product> GetAll()
        {
            return this._productDal.GetAll();
        }

       public Product Get(int Id)
        {
            return this._productDal.Get(Id);
        }

        public int Update(Product product)
        {
            return this._productDal.Update(product);
        }

        public int Add(Product product)
        {
            return this._productDal.Add(product);
        }

        public int Delete(Product product)
        {
            return this._productDal.Delete(product);
        }


    }
}
