using MyFirst.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirst.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Knife> favKnife { get; set; }
    }
}
