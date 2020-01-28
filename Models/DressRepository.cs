using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JennsClothingShop.Models
{
    public class DressRepository : IDressRepositry
    {
        private readonly AppDbContext _appDbContext;
        public DressRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Dress> AllDresses
        {

            get
            {
                return _appDbContext.Dresses.Include(c => c.Category);
            }
        }

        public IEnumerable<Dress> DressesInTemecula
        {
            get 
            {
                return _appDbContext.Dresses.Include(c => c.Category).Where(d => d.IsInStockTemecula);


            }
            
        }

        public Dress GetDressById(int dressid)
        {
            return _appDbContext.Dresses.FirstOrDefault(d => d.DressId == dressid);
        }
    }
}
