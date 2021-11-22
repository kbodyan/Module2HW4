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
    public class FindAnimalByKindService : IFindAnimalByKindService
    {
        public Animal[] FindAnimalByKind(Animal[] section, AnimalKinds kind)
        {
            var result = new Animal[section.Length];
            var k = 0;
            for (var i = 0; i < section.Length; i++)
            {
                if (section[i].Kind == kind)
                {
                    result[k++] = section[i];
                }
            }

            if (k > 0)
            {
                Array.Resize<Animal>(ref result, k);
                return result;
            }

            return null;
        }
    }
}
