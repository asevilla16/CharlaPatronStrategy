using PatronEstrategia.AppService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatronEstrategia.Strategy
{
    public interface ICharactersAppServiceStrategy
    {
        ICharactersAppService GetCharactersAppServiceStrategy(string type);
    }
}
