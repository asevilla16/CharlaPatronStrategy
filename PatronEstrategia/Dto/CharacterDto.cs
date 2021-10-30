using PatronEstrategia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatronEstrategia.Dto
{
    public class CharacterDto
    {
        public Jedi Jedi { get; set; }
        public Sith Sith { get; set; }
        public Droid Droid { get; set; }

    }
}
