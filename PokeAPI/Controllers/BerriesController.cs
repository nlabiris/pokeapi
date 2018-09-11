using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PokeAPI.Models;
using PokeAPI.Contexts;

namespace PokeAPI.Controllers {
    public class BerriesController : ApiController {
        private readonly BerryContext _berryCtx = new BerryContext();

        [HttpGet]
        [Route("api/berries")]
        public IEnumerable<Berry> GetAllBerries() {
            return _berryCtx.AllBerries();
        }

        [HttpGet]
        [Route("api/berries/{berry_id}")]
        public IHttpActionResult RetrieveBerry(int berry_id) {
            Berry berry = _berryCtx.GetBerry(berry_id);
            if (berry == null) {
                return NotFound();
            }
            return Ok(berry);
        }
    }
}
