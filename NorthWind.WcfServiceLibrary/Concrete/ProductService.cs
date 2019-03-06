using NorthWind.Dal.Abstract;
using NorthWind.Dal.Concrete.EntityFramework;
using NorthWind.Entities.Concrete;
using NorthWind.Interfaces;
using NorthWindBussinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.WcfServiceLibrary.Concrete
{
    public class ProductService:IProductService
    {

        //Hiçbir servis sınıfının constructoru olamaz. Bu bir soa standardıdır...

        //ProductManager' ın bu şekilde instance alınması yanlış. Bunu çözmek için bir instance provider yazılacak...

        /*
         * WCFIISHost --> WebConfig içine aşağıdaki kod yazılır...
         * 
         <serviceActivations>
         <add service="NorthWind.WcfServiceLibrary.Concrete.ProductService" relativeAddress="ProductService.svc"/>
         </serviceActivations>

         Anlamı   NorthWind.WcfServiceLibrary.Concrete.ProductService adresindeki servisi ProductService.svc adında yayına çıkar...
         */

        ProductManager productManager = new ProductManager(new EfProductDal());

        public List<Product> GetAll()
        {
            return productManager.GetAll();
        }

        public Product Get(int Id)
        {
            return productManager.Get(Id);
        }

        public int Update(Product product)
        {
            return productManager.Update(product);
        }

        public int Add(Product product)
        {
            return productManager.Add(product);
        }

        public int Delete(Product product)
        {
            return productManager.Delete(product);
        }
    }
}
