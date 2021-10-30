using PatronEstrategia.Dto;
using PatronEstrategia.Models;
using PatronEstrategia.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatronEstrategia.AppService
{
    public interface ICharactersAppService
    {
        string Type { get; }

        CharacterDto AddCharacter(CharactersRequest request);
        string Attack();

    }
}
