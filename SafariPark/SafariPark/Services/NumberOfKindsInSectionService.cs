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
    public class NumberOfKindsInSectionService : INumberOfKindsInSectionService
    {
        public int[] NumberOfKindsInSection(Animal[] section)
        {
            var kinds = Enum.GetValues<AnimalKinds>().Length;
            var result = new int[kinds];
            for (var i = 0; i < section.Length; i++)
            {
                result[(int)section[i].Kind]++;
            }

            return result;
        }
    }
}
