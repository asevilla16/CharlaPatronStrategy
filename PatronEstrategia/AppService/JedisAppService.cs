using PatronEstrategia.Context;
using PatronEstrategia.Dto;
using PatronEstrategia.Models;
using PatronEstrategia.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatronEstrategia.AppService
{
    public class JedisAppService : ICharactersAppService
    {
        private readonly CharactersContext _context;
        public string Type
        {
            get
            {
                return "Jedi";
            }
        }

        public JedisAppService(CharactersContext context)
        {
            _context = context;
        }

        public CharacterDto AddCharacter(CharactersRequest request)
        {
            _context.Add(request.Jedi);
            _context.SaveChanges();

            var res = new CharacterDto
            {
                Jedi = request.Jedi
            };

            return res;
            
        }

        public string Attack()
        {
            return "Ataque con sable de luz";
        }
    }
}
