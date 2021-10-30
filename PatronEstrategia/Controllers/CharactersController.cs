using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PatronEstrategia.AppService;
using PatronEstrategia.Context;
using PatronEstrategia.Dto;
using PatronEstrategia.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatronEstrategia.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharactersController : ControllerBase
    {
        private readonly IUnitOfWork _charactersAppService;

        public CharactersController(IUnitOfWork charactersAppService)
        {
            _charactersAppService = charactersAppService;
        }

        [HttpGet]
        public ActionResult<string> GetAttack(string type)
        {
            var attack = _charactersAppService.charactersAppService.Attack(type);

            return Ok(attack);
        }

        [HttpPost]
        public ActionResult<CharacterDto> CreateCharacter(CharactersRequest request)
        {
            var res = _charactersAppService.charactersAppService.Add(request);

            return Ok(res);
        }
    }
}
