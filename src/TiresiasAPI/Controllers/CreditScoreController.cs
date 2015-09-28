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
            //Will implement scenario
            return Ok(new
            {
                Score = 750.0,
                
                Lenders = new List<Default>() { 
                                                new Default()  {
                                                                    Lender = "LLoyds",
                                                                    Products = new List<string> {"Credit Card","Unsecured Loan"},
                                                                    Balance = 0,
                                                                    PaidAmount = 26000,
                                                                    Datetime= DateTime.Now.AddYears(-5), 
                                                                    Status = Status.Satisfied
                                                                }
                                              }
            });
        }
    }
}
