using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FraudAPI.Model.Order;
using FraudApi.Model;
using FraudApi.Client;

namespace FraudApi.Controllers
{

    [Route("/[controller]")]
    [ApiController]
    public class OrderFraudController : ControllerBase
    {

        //POST api/OrderFraud
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public ActionResult<double> Create( /*[FromBody]*/ OrderData order)
        {
            var transactionData = GetTransactionDataFromOrder(order);

            var fraudMLClient = new FraudMLClient();
            var fraudVal = fraudMLClient.GetMLFraudResult(transactionData);

            return fraudVal;
        }

        private TransactionData GetTransactionDataFromOrder(OrderData order)
        {
            List<string> columnNames = new List<string>() { "NumberOfItems", "TransactionTotal", "NumberOfVoid", "Tp1" };
            List<string> values = new List<string>() { "3", "3000", "3", "0" };

            TransactionData transactionData = new TransactionData(columnNames, values);
            return transactionData;
        }


       

    }
}
