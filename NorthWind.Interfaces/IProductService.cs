using NorthWind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Interfaces
{
    [ServiceContract] //Bir sınıfı wcf servisi olarak çıkarmak için yazarız
   
    public interface IProductService
    {
        [OperationContract] //Bir methodu wcf servisi olarak çıkarmak için yazarız
        List<Product> GetAll();

        [OperationContract]
        Product Get(int Id);
        [OperationContract]
        int Update(Product product);
        [OperationContract]
        int Add(Product product);
        [OperationContract]
        int Delete(Product product);
    }
}
