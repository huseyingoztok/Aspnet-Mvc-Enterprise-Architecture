using NorthWind.Dal.Concrete.EntityFramework;
using NorthWind.Entities.Concrete;
using NorthWind.Interfaces;
using NorthWind.MvcWebUI.Models;
using NorthWind.WcfServiceLibrary.Concrete;
using NorthWindBussinessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        public int PageSize = 5;
        //private ProductManager productManager = new ProductManager(new EfProductDal());
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        // GET: Product
        public ActionResult Index(int page = 0,int category=0)
        {
            var products = category == 0 ? _productService.GetAll() : _productService.GetAll().Where(p=>p.CategoryID==category).ToList();



            return View(new ProductViewModel
            {
                products=products.Skip(page * PageSize).Take(PageSize).ToList(),
                pagingInfo=new PagingInfo
                {
                    CurrCategory=category,
                    CurrPage=page,
                    TotalItems= products.Count,
                    ItemsPerPage=PageSize
                }
                
                
            });
        }
    }
}