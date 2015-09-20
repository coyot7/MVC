using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Store.Domain.Entities;

namespace Store3.Models
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PageInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}