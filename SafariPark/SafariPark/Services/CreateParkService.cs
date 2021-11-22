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
    public class CreateParkService : ICreateParkService
    {
        public Animal[] CreatePark()
        {
            var park = new Animal[]
            {
                new Predator { Kind = AnimalKinds.Lion, Nickname = "King", Id = 1, Weight = 100, Diet = "everybody", EatAnotherPredators = false, MeatFeedPerDay = 15, NeedPool = false },
                new Predator { Kind = AnimalKinds.Wolf, Nickname = "Sherhan", Id = 2, Weight = 40, Diet = "everybody", EatAnotherPredators = false, MeatFeedPerDay = 5, NeedPool = false },
                new Herbivorous { Kind = AnimalKinds.Deer, Nickname = "Santa", Id = 3, Weight = 300, Diet = "plants", NeedPool = false, FoodPerDay = 30 },
                new Herbivorous { Kind = AnimalKinds.Buffalo, Nickname = "Buff", Id = 4, Weight = 500, Diet = "plants", NeedPool = false, FoodPerDay = 50 },
                new Bird { Kind = AnimalKinds.Eagle, Nickname = "Bird", Weight = 15, Id = 5, Diet = "litle animals", CanFlyAway = true, NeedPool = false },
                new SeaWaterFish { Kind = AnimalKinds.Shark, Nickname = "Jaw", Id = 6, Weight = 150, Diet = "everybody", EatAnotherFish = true, NeedPool = true },
                new Reptile { Kind = AnimalKinds.Crocodile, Nickname = "Chroco", Id = 7, Weight = 120, Diet = "everybody", NeedPool = true },
                new Amphibian { Kind = AnimalKinds.Frog, Nickname = "Queen", Id = 8, Diet = "doesnt know", Weight = 0.25, NeedPool = true }
            };
            return park;
        }
    }
}
