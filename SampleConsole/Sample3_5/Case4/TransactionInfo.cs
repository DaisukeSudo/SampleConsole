using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample3_5.Case4
{
    public class TransactionInfo
    {
        public string ConnectionString { get; }

        public TransactionInfo(string connectionString)
        {
            ConnectionString = connectionString;
        }
    }
}
