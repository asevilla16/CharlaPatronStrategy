using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatronEstrategia.Models
{
    public class Droid : Character
    {
        public int id { get; set; }
        public string Rank { get; set; }
        public string Weapon { get; set; }
        public string Owner { get; set; }


    }
}
