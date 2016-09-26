using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemQuiche.Modelos
{
    public class ProductInformation
    {
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
        private int _categoryID;
        public int CategoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }
        private float _price;
        public float Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}
