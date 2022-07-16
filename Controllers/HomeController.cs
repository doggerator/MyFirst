using Microsoft.AspNetCore.Mvc;
using MyFirst.Data.Interfaces;
using MyFirst.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirst.Controllers
{
    public class HomeController : Controller
    {
        private IAllKnifes _knifeRep;

        public HomeController(IAllKnifes knifeRep)
        {
            _knifeRep = knifeRep;
        }

        public ViewResult Index()
        {
            var homeKnife = new HomeViewModel
            {
                favKnife = _knifeRep.GetFavKnifes
            };
                
            return View(homeKnife);
        }
    }
}
