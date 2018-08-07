using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using FraudApi.Model;

namespace FraudApi.Client
{

    class FraudMLClient
    {
        private HttpClient client;

        public FraudMLClient()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:5002/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public double GetMLFraudResult(TransactionData transactionData)
        {
            var frudadVal = RunAsync(transactionData).GetAwaiter().GetResult();
            return frudadVal;
        }     

        private async Task<double> RunAsync(TransactionData transactionData)
        {
            try
            {            
                var fraudVal = await CreateTransactionAsync(transactionData);
                return fraudVal;
            }
            catch (Exception e)
            {
                return 77777;
            }
           
        }

        async Task<double> CreateTransactionAsync(TransactionData transactionData)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "transactions", transactionData);
            response.EnsureSuccessStatusCode();

            double returnValue = response.Content.ReadAsAsync<double>().Result;
            return returnValue;
        }

       
    }

   
}
