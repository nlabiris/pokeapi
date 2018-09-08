using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PokeAPI.Models;
using PokeAPI.Contexts;

namespace PokeAPI.Controllers {
    public class AbilitiesController : ApiController {
        private readonly AbilityContext _abilityCtx = new AbilityContext();

        [HttpGet]
        [Route("api/abilities")]
        public IEnumerable<Ability> GetAllAbilities() {
            return _abilityCtx.All();
        }
    }
}
