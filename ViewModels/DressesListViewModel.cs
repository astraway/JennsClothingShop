using JennsClothingShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JennsClothingShop.ViewModels
{
    public class DressesListViewModel
    {
        public IEnumerable<Dress> Dresses { get; set; }

        public string CurrentCategory { get; set; }
    }
}
