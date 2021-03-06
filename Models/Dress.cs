﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JennsClothingShop.Models
{
    public class Dress
    {
        public int DressId { get; set; }
        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }

        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }

        public bool IsInStockTemecula { get; set; }

        public bool InStock { get; set; }

        public int CategoryID { get; set; }

        public Category Category { get; set; }

        public string Notes { get; set; }
    }
}
