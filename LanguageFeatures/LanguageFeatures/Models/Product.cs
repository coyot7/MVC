﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public int productID {get; set;}
        public string name {get; set;}
        public string description { get; set; }
        public decimal price { get; set; }
        public string category { get; set; }

    }
}