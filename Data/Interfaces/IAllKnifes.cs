using MyFirst.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirst.Data.Interfaces
{
    public interface IAllKnifes
    {
        IEnumerable<Knife> Knifes { get; }
        IEnumerable<Knife> GetFavKnifes { get; }
        Knife getObjectKnife(int knifeId);

    }
}
