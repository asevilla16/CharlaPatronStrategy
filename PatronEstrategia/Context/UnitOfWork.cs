using PatronEstrategia.AppService;
using PatronEstrategia.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatronEstrategia.Context
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ICharactersAppServiceStrategy _strategy;

        public UnitOfWork(ICharactersAppServiceStrategy strategy)
        {
            _strategy = strategy;
        }

        public CharactersAppService charactersAppService => 
            new CharactersAppService(_strategy);
    }
}
