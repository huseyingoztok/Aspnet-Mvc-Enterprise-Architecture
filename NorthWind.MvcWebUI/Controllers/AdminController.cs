using NorthWind.Entities.Concrete;
using NorthWind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWind.MvcWebUI.Controllers
{
    public class AdminController : Controller
    {
        private IProductService _productService;
        public AdminController(IProductService productService)
        {
            _productService = productService;
        }
        /*
     * TODO Add ve Edit' i yaz ve 12. dersten devam et ...
     * 
     */
        // GET: Admin
        public ActionResult Index()
        {

            return View("Index",_productService.GetAll());
        }

        public ActionResult Edit(int id)
        {

            return View("Edit",_productService.Get(id));
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            int res = _productService.Update(product);
            if (res>0)
            {
                return RedirectToAction("Index", _productService.GetAll());
            }
            return View("Edit",product);
        }


        public ActionResult CreateNew()
        {
            return View(new Product());
        }

        [HttpPost]
        public ActionResult CreateNew(Product product)
        {
            int res=_productService.Add(product);
            if (res>0)
            {
                return RedirectToAction("Index",_productService.GetAll());
            }
            return View("CreateNew",product);
        }

        public ActionResult Delete(int id)
        {
            Product product = _productService.Get(id);
            if (product!=null)
            {
                int result = _productService.Delete(product);
                if (result>0)
                {
                    return RedirectToAction("Index",_productService.GetAll());
                }
                else
                {
                    return RedirectToAction("Index", _productService.GetAll());
                }
            }
            else
            {
                return RedirectToAction("Index", _productService.GetAll());
            }
        }
    }
}