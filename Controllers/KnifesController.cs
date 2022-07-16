using Microsoft.AspNetCore.Mvc;
using MyFirst.Data.Interfaces;
using MyFirst.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirst.Controllers
{
    public class KnifesController : Controller
    {
        //тут функции, которые возвращают ньюрезалт
        private readonly IAllKnifes _allKnifes;
        private readonly IKnifesCategory _allCategories;

        public KnifesController(IAllKnifes iAllKnifes, IKnifesCategory iKnifesCategory)
        {
            _allKnifes = iAllKnifes;
            _allCategories = iKnifesCategory;
        }

        //возвращает хтмл страницу
        public ViewResult List()
        {
            ViewBag.Title = "Страница с ножами";
            KnifesListViewModel obj = new KnifesListViewModel();
            obj.allKnifes = _allKnifes.Knifes;
            obj.currCategory = "Ножи";
            

            return View(obj);
        }

    }
}
