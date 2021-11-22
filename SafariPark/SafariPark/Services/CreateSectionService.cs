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
   public class CreateSectionService : ICreateSectionService
    {
        public Animal[] CreateSection(Animal[] park, int size)
        {
            var section = new Animal[size];
            for (var i = 0; i < size && i < park.Length; i++)
            {
                section[i] = park[i];
            }

            return section;
        }
    }
}
