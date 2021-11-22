using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SafariPark.Models.Helpers;

namespace SafariPark.Models
{
    public abstract class Animal
    {
        public string Nickname { get; set; }
        public AnimalKinds Kind { get; set; }
        public double Weight { get; set; }
        public int Id { get; set; }
        public string Diet { get; set; }
        public bool NeedPool { get; set; }
    }
}
