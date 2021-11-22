using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariPark.Models
{
    public abstract class Animal
    {
        public string Nickname { get; set; }
        public string Kind { get; set; }
        public int Id { get; set; }
        public string Diet { get; set; }
        public bool NeedPool { get; set; }
    }
}
