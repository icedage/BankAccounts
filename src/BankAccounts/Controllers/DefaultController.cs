using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace BankAccountsAPI.Controllers
{
    public class DefaultController : ApiController
    {
        // GET: Default
        public IHttpActionResult Get()
        {
            return Ok();
        }
    }
}