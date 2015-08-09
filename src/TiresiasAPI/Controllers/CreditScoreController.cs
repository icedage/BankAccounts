using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using TiresiasAPI.Models;

namespace TiresiasAPI.Controllers
{
    public class CreditScoreController : ApiController
    {
        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            return Ok();
        }

        [HttpPost]
        public async Task<IHttpActionResult> Post(CreditReportRequest request)
        {

            return Ok(  new { 
                                Score= request.Score, 
                                Lenders= request.Defaults 
                            }
                      );
        }
    }
}
