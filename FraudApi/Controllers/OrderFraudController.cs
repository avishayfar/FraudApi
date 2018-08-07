using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FraudAPI.Model.Order;
using FraudApi.Model;
using FraudApi.Client;
using FraudApi.Transaction;

namespace FraudApi.Controllers
{

    [Route("/[controller]")]
    [ApiController]
    public class OrderFraudController : ControllerBase
    {

        TransactionDataCreatorFactory TransactionDataCreatorFactory = new TransactionDataCreatorFactory();

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
            var transactionDataCreator = TransactionDataCreatorFactory.GetTransactionDataCreator();
            var transactionData = transactionDataCreator.Create(order);
            return transactionData;
        }


       

    }
}
