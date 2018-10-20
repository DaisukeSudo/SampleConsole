using System;
using System.Collections.Generic;
using System.Text;

namespace SampleConsole.Sample2.Case2
{
    public class Product
    {
        private string productCode;
        private string productName;
        private Decimal price;

        public Product(
            string productCode,
            string productName,
            Decimal price)
        {
            this.productCode = productCode;
            this.productName = productName;
            this.price = price;
        }

        public string getProductCode() => this.productCode;
        public string getProductName() => this.productName;
        public Decimal getPrice() => this.price;
    }
}
