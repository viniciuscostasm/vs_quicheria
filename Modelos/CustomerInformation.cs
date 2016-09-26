using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemQuiche.Modelos
{
    public class CustomerInformation
    {
        private int _customerId;
        public int CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }
        private string _customerName;
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }
        private string _address;
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }
        private string _city;
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        private string _contactNo;
        public string ContactNo
        {
            get { return _contactNo; }
            set { _contactNo = value; }
        }
        private string _contactNo1;
        public string ContactNo1
        {
            get { return _contactNo1; }
            set { _contactNo1 = value; }
        }
        private string _email;
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _notes;
        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }
    }
}

