using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Models
{
    public class Predator : MammalsAnimal
    {
        public double MeatFeedPerDay { get; set; }
        public bool EatAnotherPredators { get; set; }
    }
}
