using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Infrastructure.Managers.Interfaces;
using Infrastructure.Models;
using Infrastructure.Core.Business.Interfaces;

namespace PokeAPI.Controllers {
    public class AbilitiesController : ApiController {
        private readonly IAbilityManager abilityManager;

        public AbilitiesController(IAbilityManager abilityManager) {
            this.abilityManager = abilityManager;
        }

        [HttpGet]
        [Route("api/abilities")]
        public IBusinessResult<Ability> GetAllAbilities() {
            return abilityManager.GetAllAbilities();
        }

        //[HttpGet]
        //[Route("api/abilities/{ability_id}")]
        //public IHttpActionResult RetrievePokemon(int ability_id) {
        //    AbilityViewModel ability = _abilityCtx.GetAbility(ability_id);
        //    if (ability == null) {
        //        return NotFound();
        //    }
        //    return Ok(ability);
        //}
    }
}
