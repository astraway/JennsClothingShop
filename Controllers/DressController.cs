using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using JennsClothingShop.Models;
using JennsClothingShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JennsClothingShop.Controllers
{
    public class DressController : Controller
    {
        // GET: /<controller>/
        private readonly IDressRepositry _dressRepository;
        private readonly ICategoryRepository _categoryRepository;

        public DressController(IDressRepositry dressRepositry,  ICategoryRepository categoryRepository)
        {
            _dressRepository = dressRepositry;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List()
        {
            DressesListViewModel dressesListViewModel = new DressesListViewModel();

            dressesListViewModel.Dresses = _dressRepository.AllDresses;
            dressesListViewModel.CurrentCategory = "Long Dresses";
            return View(dressesListViewModel);
        
        }

    }
}
