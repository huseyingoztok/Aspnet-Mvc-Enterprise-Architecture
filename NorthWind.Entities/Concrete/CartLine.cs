using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entities.Concrete
{
    public class CartLine
    {
        public Product product { get; set; }
        public int Quantity { get; set; }
        
    }

    public class Cart
    {
        List<CartLine> cartLines = new List<CartLine>();
        public void AddToCart(Product product, int Quantity)
        {
            CartLine cartLine = cartLines.FirstOrDefault(p => p.product.ProductId == product.ProductId);

            if (cartLine==null)
            {
                cartLines.Add(new CartLine {product=product, Quantity=Quantity });
            }
            else
            {
                cartLine.Quantity += Quantity;
            }
        }

        public void RemoveProduct(int ProductId,int Quantity)
        {
            CartLine cartLine = cartLines.FirstOrDefault(x => x.product.ProductId == ProductId);

            if (cartLine!=null&& cartLine.Quantity>=Quantity)
            {
                cartLine.Quantity -= Quantity;
                if (cartLine.Quantity==0)
                {
                    cartLines.Remove(cartLine);
                }
            }
        }

        public void ClearCart()
        {
            cartLines.Clear();
        }

        public decimal TotalPrice
        {
            get { return cartLines.Sum(x => x.product.UnitPrice*x.Quantity); }
        }

        public List<CartLine> lines
        {
            get { return cartLines; }
        }
    }
}
