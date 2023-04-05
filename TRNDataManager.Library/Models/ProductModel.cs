﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRNDataManager.Library.Models
{
    public class ProductModel
    { 
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string Descriptuion { get; set; }
        public decimal RetailPrice { get; set; }
        public int QuantityInStock { get; set; }
    }
}