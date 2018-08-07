using FraudApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FraudApi.Transaction
{
    class TransactionDataCreatorFactory
    {
        public ITransactionDataCreator GetTransactionDataCreator()
        {
            var transactionDataCreator = new Phase3TransactionDataCreator();
            return transactionDataCreator;
        }
    }
}
