using NorthWind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace NorthWind.Interfaces
{
    [ServiceContract]
    
    public interface ICategoryService
    {
        [OperationContract] //Bir methodu wcf servisi olarak çıkarmak için yazarız
        List<Category> GetAll();
    }
}
