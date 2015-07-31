using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace TiresiasAPI.Controllers
{
    public class CreditScoreController : ApiController
    {
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            return Ok();
        }
    }
}
