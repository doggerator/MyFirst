using MyFirst.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirst.ViewModels
{
    public class KnifesListViewModel
    {
        public IEnumerable<Knife> allKnifes { get; set; }

        public string currCategory { get; set; }
    }
}
