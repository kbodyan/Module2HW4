using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Models;
using SafariPark.Models.Helpers;

namespace SafariPark.Services.Abstractions
{
    public interface IFindAnimalByKindService
    {
        Animal[] FindAnimalByKind(Animal[] section, AnimalKinds kind);
    }
}
