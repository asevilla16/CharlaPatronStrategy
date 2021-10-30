using PatronEstrategia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatronEstrategia.Request
{
    public class CharactersRequest
    {
        public Jedi Jedi { get; set; }
        public Sith Sith { get; set; }
        public Droid Droid { get; set; }
        public string Type { get; set; }
    }
}
