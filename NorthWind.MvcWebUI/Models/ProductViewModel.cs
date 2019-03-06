using NorthWind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthWind.MvcWebUI.Models
{
    public class ProductViewModel
    {
        public List<Product> products;
        public PagingInfo pagingInfo;
    }

    
}