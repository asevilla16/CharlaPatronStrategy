using PatronEstrategia.Context;
using PatronEstrategia.Dto;
using PatronEstrategia.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatronEstrategia.AppService
{
    public class SithsAppService : ICharactersAppService
    {
        private readonly CharactersContext _context;
        public string Type
        {
            get
            {
                return "Sith";
            }
        }

        public SithsAppService(CharactersContext context)
        {
            _context = context;
        }

        public CharacterDto AddCharacter(CharactersRequest request)
        {
            _context.Add(request.Sith);
            _context.SaveChanges();

            var res = new CharacterDto
            {
                Sith = request.Sith
            };

            return res;

        }

        public string Attack()
        {
            return "Ataque con rayos de la fuerza";
        }
    }
}
