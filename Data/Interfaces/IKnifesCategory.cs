using MyFirst.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirst.Data.Interfaces
{
    public interface IKnifesCategory
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
