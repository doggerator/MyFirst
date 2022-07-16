using MyFirst.Data.Interfaces;
using MyFirst.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirst.Data.Repos
{
    public class CategoryRepos : IKnifesCategory
    {
        private readonly AppDBContent appDBContent;

        public CategoryRepos(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
