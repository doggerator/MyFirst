using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyFirst.Data.Models;

namespace MyFirst.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {

        }

        public DbSet<Knife> Knive { get; set; }

        public DbSet<Category> Category { get; set; }



    }
}
