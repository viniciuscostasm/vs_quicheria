using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemQuiche.Modelos
{
    public class ProductSoldInformation
    {
        private int _Id;
        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        private string _invoiceNo;
        public string InvoiceNo
        {
            get { return _invoiceNo; }
            set { _invoiceNo = value; }
        }
        private int _productID;
        public int ProductID
        {
            get { return _productID; }
            set { _productID = value; }
        }
        private string _productName;
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        private float _price;
        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }
        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }
        private float _totalAmount;
        public float TotalAmount
        {
            get { return _totalAmount; }
            set { _totalAmount = value; }
        }
    }
}
