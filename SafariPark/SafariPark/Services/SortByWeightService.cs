using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Models;
using SafariPark.Models.Helpers;
using SafariPark.Services.Abstractions;

namespace SafariPark.Services
{
    public class SortByWeightService : ISortByWeightService
    {
        public void SortByWeight(Animal[] animals)
        {
            var comparer = new AnimalsComparerByWeight();
            Array.Sort(animals, comparer);
        }
    }
}
