using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MyFirst.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirst.Data
{
    public class DBObjects
    {

        public static void Initial(AppDBContent content)
        {
                      
            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }

            if (!content.Knive.Any())
            {
                content.AddRange(
                    new Knife { name = "Bestech", shortDesc = "Лучший", longDesc = "Премиальный китай", img = "/img/bt.jpg", price = 5000, isFavourite = true, isAvailable = true, Category = Categories["Нормальные"] },
                    new Knife { name = "ColdSteel", shortDesc = "Норм", longDesc = "Обычный неплохой китай", img = "/img/cs.jpg", price = 4000, isFavourite = false, isAvailable = true, Category = Categories["Нормальные"] },
                    new Knife { name = "Microtech", shortDesc = "Зачем?", longDesc = "Что-то на богатом", img = "/img/mt.jpg", price = 19000, isFavourite = false, isAvailable = true, Category = Categories["Фронталки"] }
                    );
            }

            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(category == null)
                {
                    var list = new Category[]
                    {
                        new Category {categoryName = "Нормальные", desc = "То что нужно"},
                        new Category {categoryName = "Фронталки", desc = "Эффектно и бесполезно"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        category.Add(el.categoryName, el);
                    }
                }
                return category;
            }
        }

    }
}
