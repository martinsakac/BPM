using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PV207.Controllers
{
    public class SuppliersController : ApiController
    {
        [HttpGet]
        [Route("api/suppliers")]
        public IHttpActionResult VerifyOrder(string productName, int price, int amount)
        {
            Random rnd = new Random();
            int value = rnd.Next(2);

            if (value == 0)
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
