using FraudApi.Model;
using FraudAPI.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FraudApi.Transaction
{
    public class Phase3TransactionDataCreator : ITransactionDataCreator
    {
     
        public TransactionData Create(OrderData order)
        {
            var columnsAndValues = GetColumnsAndValues(order);

            TransactionData transactionData = new TransactionData(columnsAndValues);
            return transactionData;
        }

        private Dictionary<string, string> GetColumnsAndValues(OrderData order)
        {
            var columnsAndValues = new Dictionary<string, string>();

            // items Nzd
            string itemNzd = GetItemNzd(order);
            columnsAndValues.Add("ItemNzd", itemNzd);

            //Trx total Nzd
            string totalNzd = GetTrxTotalNzd(order);
            columnsAndValues.Add("totalNzd", totalNzd);

            //Voided items Nzd
            string voidedItemsNzd = GetVoidedItemsNzd(order);
            columnsAndValues.Add("voidedItemsNzd", voidedItemsNzd);

            //Value voided lines Nzd
            string voidedLineNzd = GetVoidedLineNzd(order);
            columnsAndValues.Add("voidedLineNzd", voidedLineNzd);

            //distinct items Nzd
            string distinctItemNzd = GetDistinctItemNzd(order);
            columnsAndValues.Add("distinctItemNzd", distinctItemNzd);

            //Early Morning
            string earlyMorning = GetEarlyMorning(order);
            columnsAndValues.Add("earlyMorning", earlyMorning);

            //late morning
            string lateMorning = GetLateyMorning(order);
            columnsAndValues.Add("lateMorning", lateMorning);

            //lunch
            string lunch = GetLunch(order);
            columnsAndValues.Add("lunch", lunch);

            //afternoon
            string afternoon = GetAfterNoon(order);
            columnsAndValues.Add("afternoon", afternoon);

            //evening
            string evening = GetEvening(order);
            columnsAndValues.Add("evening", evening);

            //late night
            string lateNight = GetLateNight(order);
            columnsAndValues.Add("lateNight", lateNight);

            //Quantitiy items Nzd
            string quantitiyItemsNzd = GetQuantitiyItemsNzd(order);
            columnsAndValues.Add("quantitiyItemsNzd", quantitiyItemsNzd);

            return columnsAndValues;
        }

        private string GetItemNzd(OrderData order)
        {
            return "-0.86726123";
        }

        private string GetTrxTotalNzd(OrderData order)
        {
            return "-0.774671";
        }

        private string GetVoidedItemsNzd(OrderData order)
        {
            return "-0.1025641";
        }

        private string GetVoidedLineNzd(OrderData order)
        {
            return "-0.25470374";
        }

        private string GetDistinctItemNzd(OrderData order)
        {
            return "-0.82614";
        }

        private string GetEarlyMorning(OrderData order)
        {
            return "0";
        }

        private string GetLateyMorning(OrderData order)
        {
            return "0";
        }

        private string GetLunch(OrderData order)
        {
            return "0";
        }

        private string GetAfterNoon(OrderData order)
        {
            return "0";
        }

        private string GetEvening(OrderData order)
        {
            return "1";
        }

        private string GetLateNight(OrderData order)
        {
            return "0";
        }

        private string GetQuantitiyItemsNzd(OrderData order)
        {
            return "-0.5709531";
        }
 
    }
}
