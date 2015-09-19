using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Razor.Models;
using Ninject;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        Product myProduct = new Product
        {
            ProductID = 1,
            Name = "Kajak",
            Description = "Jednoosobaw łódka",
            Category = "Sporty wodne",
            Price = 275M
        };

        Product[] products = {
                                 new Product {Name = "Kajak", Category = "Sporty wodne", Price = 275M},
                                 new Product {Name = "Kamizelka ratunkowa", Category = "Sporty wodne", Price = 48.95M},
                                 new Product {Name = "Piłka nożna", Category = "Piłka nożna", Price = 19.50M},
                                 new Product {Name = "Flaga narożna", Category = "Piłka nożna", Price = 34.95M}
                             };

        // GET: Home
        public ActionResult Index()
        {
            IKernel ninjectKernel = new StandardKernel();
            ninjectKernel.Bind<IValueCalculator>().To<LinqValueCalculator>();

            IValueCalculator calc = ninjectKernel.Get<IValueCalculator>();

            ShoppingCart cart = new     ShoppingCart(calc) { Products = products };
            decimal totalValue = cart.CalculateProductTotal();

            return View(totalValue);
        }

        public ActionResult NameAndPrice()
        {
            return View(myProduct);
        }
    }
}