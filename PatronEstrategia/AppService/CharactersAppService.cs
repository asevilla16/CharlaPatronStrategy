using PatronEstrategia.Context;
using PatronEstrategia.Dto;
using PatronEstrategia.Models;
using PatronEstrategia.Request;
using PatronEstrategia.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatronEstrategia.AppService
{
    public class CharactersAppService
    {
        private readonly ICharactersAppServiceStrategy _mainCharactersAppServiceStrategy;

        public CharactersAppService(ICharactersAppServiceStrategy mainCharactersAppServiceStrategy)
        {
            _mainCharactersAppServiceStrategy = mainCharactersAppServiceStrategy;
        }

        public CharacterDto Add(CharactersRequest request)
        {
            ICharactersAppService charactersStrategy = _mainCharactersAppServiceStrategy.GetCharactersAppServiceStrategy(request.Type);

            CharacterDto character = charactersStrategy.AddCharacter(request);

            return character;
        }

        public string Attack(string request)
        {
            ICharactersAppService charactersStrategy = _mainCharactersAppServiceStrategy.GetCharactersAppServiceStrategy(request);

            string character = charactersStrategy.Attack();

            return character;
        }
    }
}
