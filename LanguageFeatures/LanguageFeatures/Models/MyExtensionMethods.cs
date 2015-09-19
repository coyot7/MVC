using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    static public class MyExtensionMethods
    {
        static public decimal TotalPrice(this IEnumerable<Product> productEnum)
        {
            decimal total = 0;
            foreach (Product prod in productEnum)
            {
                total += prod.price;
            }
            return total;
        }
    }
}