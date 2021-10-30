using PatronEstrategia.AppService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatronEstrategia.Strategy
{
    public class CharactersAppServiceStrategy : ICharactersAppServiceStrategy
    {
        private readonly IEnumerable<ICharactersAppService> _availableStrategiesAppService;

        public CharactersAppServiceStrategy(IEnumerable<ICharactersAppService> availableStrategiesAppService)
        {
            _availableStrategiesAppService = availableStrategiesAppService;
        }

        public ICharactersAppService GetCharactersAppServiceStrategy(string type)
        {
            ICharactersAppService strategy = _availableStrategiesAppService.FirstOrDefault(x => x.Type == type);

            return ValidateSupportedStrategy(strategy, type);
        }

        private ICharactersAppService ValidateSupportedStrategy<ICharactersAppService>(ICharactersAppService strategy, string type)
        {
            if(strategy == null)
            {
                string exceptionMessage = "Not supported";
                throw new AppDomainUnloadedException(exceptionMessage);
            }

            return strategy;
        }

    }
}
