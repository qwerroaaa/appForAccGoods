﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appForAccGoods.Model
{
    public class Product
    {
        public string Name { get; set; }
        public string Barcode { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }
        public string PhotoPath { get; set; }
    }
}
