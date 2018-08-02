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

       public  List<string> ColumnsNames { get; set; }

       public List<string> Values { get; set; }
    }
}
