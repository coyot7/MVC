using System;
using System.Collections.Generic;
using System.Web.Mvc;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Przejście do adresu URL pokazującego przykład.";
        }

        public ViewResult AutoProperty()
        {
            Product myProduct = new Product();
            myProduct.name = "Kajak";
            string productName = myProduct.name;

            return View("Result", (object)String.Format("Nazwa produktu: {0}", productName));
        }

        public ViewResult CreateProduct()
        {
            Product myProduct = new Product
            {
                productID = 100,
                name = "Kajak",
                description = "Łódka jednoosobowa",
                price = 275M,
                category = "Sporty wodne",
            };

            return View("Result", (object)String.Format("Kategoria: {0}", myProduct.category));
        }

        public ViewResult CreateCollection()
        {
            string[] stringArray = { "jabłko", "pomarańcza", "gruszka" };
            List<int> intList = new List<int> { 10, 20, 30, 40 };
            Dictionary<string, int> myDict = new Dictionary<string, int>{
                {"jabłko", 10}, {"pomarańcza", 20}, {"gruszka", 30}
            };

            ShoppingCart cart = new ShoppingCart
            {
                Products = new List<Product>{
                    new Product {name = "Kajak", price = 275M},
                    new Product {name = "Kamizelka ratunkowa", price = 48.95M},
                    new Product {name = "Piłka nożna", price = 19.50M},
                    new Product {name = "Flaga narożna", price = 34.95M}
                }
            };

            decimal cartTotal = cart.TotalPrice();

            return View("Result", (object)string.Format("Razem: {0:c}", cartTotal));
        }

        public ViewResult UseExtensionEnumerable()
        {
            IEnumerable<Product> products = new ShoppingCart{
                Products = new List<Product>{
                    new Product {name = "Kajak", price = 275M},
                    new Product {name = "Kamizelka ratunkowa", price = 48.95M},
                    new Product {name = "Piłka nożna", price = 19.50M},
                    new Product {name = "Flaga narożna", price = 34.95M}
        }
                
            };
            return View("Result");
        }
    }
}