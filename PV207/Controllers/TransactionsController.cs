using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using PV207.Models;

namespace PV207.Controllers
{
    public class TransactionsController : ApiController
    {
        
        [HttpGet]
        [Route("api/transactions/verify")]
        public IHttpActionResult VerifyTransaction()
        {
            Random rnd = new Random();
            int value = rnd.Next(3);

            if (value == 0 || value == 1)
            {
                return Ok(true);
            }
            else
            {
                return Ok(false);
            }
        }

    }
}
