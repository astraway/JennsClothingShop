using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JennsClothingShop.Models
{
    public interface IDressRepositry
    {
        IEnumerable<Dress> AllDresses { get; }

        IEnumerable<Dress> DressesInTemecula { get; }

        Dress GetDressById(int dressid);
    }
}
