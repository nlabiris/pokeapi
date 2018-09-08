using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PokeAPI.Models;
using PokeAPI.Contexts;

namespace PokeAPI.Controllers {
    public class PokemonController : ApiController {
        private readonly PokemonContext _pkmnCtx = new PokemonContext();

        [HttpGet]
        [Route("api/pokemon")]
        public IEnumerable<Pokemon> RetrieveAllPokemon() {
            return _pkmnCtx.AllPokemon();
        }

        [HttpGet]
        [Route("api/pokemon/{pokemon_id}")]
        public IHttpActionResult RetrievePokemon(int pokemon_id) {
            Pokemon pokemon = _pkmnCtx.GetPokemon(pokemon_id);
            if (pokemon == null) {
                return NotFound();
            }
            return Ok(pokemon);
        }
    }
}
