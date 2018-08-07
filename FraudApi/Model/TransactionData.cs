using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FraudApi.Model
{
    public class TransactionData
    {
        public TransactionData(List<string> columnsNames, List<string> values)
        {
            ColumnsNames = columnsNames;
            Values = values;
        }

        public TransactionData(Dictionary<string, string> columnsValues)
        {
            ColumnsNames = new List<string>();
            Values = new List<string>();

            foreach (var colValue in columnsValues)
            {
                ColumnsNames.Add(colValue.Key);
                Values.Add(colValue.Value);
            }
        }

        public  List<string> ColumnsNames { get; set; }

        public List<string> Values { get; set; }
    }
}
