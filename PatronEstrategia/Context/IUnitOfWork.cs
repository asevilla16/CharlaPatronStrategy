using PatronEstrategia.AppService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatronEstrategia.Context
{
    public interface IUnitOfWork
    {
        CharactersAppService charactersAppService { get; }
    }
}
