using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Models.Helpers
{
    public static class Extentions
    {
        public static string GiveDiet(this Animal animal)
        {
            return animal.Diet;
        }

        public static Animal FindByKind(this Animal animal, AnimalKinds kind)
        {
            if (animal.Kind == kind)
            {
                return animal;
            }

            return null;
        }
    }
}
