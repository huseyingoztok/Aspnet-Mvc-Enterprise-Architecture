using NorthWind.Entities.Concrete;
using NorthWind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NorthWind.MvcWebUI.Controllers
{
    
    public class CartController : Controller
    {
        private IProductService _productService;

        public CartController(IProductService productService)
        {
            _productService = productService;
        }
        public ActionResult Index(Cart cart)
        {          
            return View("Index",cart);
        }
        // GET: Cart
        public ActionResult AddToCart(Cart cart,int ProductId,int Quantity)
        {
            Product product=_productService.Get(ProductId);
            

            cart.AddToCart(product, Quantity);

            return RedirectToAction("Index","Product");
        }

        public ActionResult RemoveCart(Cart cart,int ProductId,int Quantity)
        {
            Product product = _productService.Get(ProductId);

            if (product!=null)
            {
                

                cart.RemoveProduct(product.ProductId, Quantity);
                return View("Index", cart);
            }
            else
            {
                return Redirect("/Product/Index");
            }
        }

        public ActionResult RemoveAllProduct(Cart cart)
        {

            cart.ClearCart();

            return View("Index",cart);
        }

        public ActionResult Checkout()
        {
            return View(new ShippingDetail());
        }

        [HttpPost]
        public ActionResult Checkout(Cart cart,ShippingDetail shippingDetail)
        {
            
            if (ModelState.IsValid)
            {
                //Managerdan veritabanına kayıt edilebilir...               
                cart.ClearCart();
                return View("Complete");
            }
            else
            {
                return View("Checkout",shippingDetail);
            }

            
        }

        public PartialViewResult GetCartSummary(Cart cart)
        {
            return PartialView("PartialSummary",cart);
        }
    }

   
}