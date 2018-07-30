using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.Order;

namespace FraudApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrderFraudController : ControllerBase
    {

        //POST api/OrderFraud
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public ActionResult<double> Create([FromBody] OrderData order)
        {
            var t = order;
            return 0.5;
        }


       

    }
}
