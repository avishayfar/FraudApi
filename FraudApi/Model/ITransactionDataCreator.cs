using FraudAPI.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FraudApi.Model
{
    interface ITransactionDataCreator
    {
        TransactionData Create(OrderData order);
    }
}
