using Microsoft.EntityFrameworkCore;
using MyFirst.Data.Interfaces;
using MyFirst.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirst.Data.Repos
{
    public class KnifeRepos : IAllKnifes
    {
        private readonly AppDBContent appDBContent;

        public KnifeRepos(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Knife> Knifes => appDBContent.Knive.Include(c => c.Category);

        public IEnumerable<Knife> GetFavKnifes => appDBContent.Knive.Where(p => p.isFavourite).Include(c => c.Category);

        public Knife getObjectKnife(int knifeId) => appDBContent.Knive.FirstOrDefault(p => p.id == knifeId);
        
    }
}
