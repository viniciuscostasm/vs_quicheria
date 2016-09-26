using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemQuiche.Modelos
{
    public class Invoice_InfoInformation
    {
        private string _invoiceNo;
        public string InvoiceNo
        {
            get { return _invoiceNo; }
            set { _invoiceNo = value; }
        }
        private string _invoiceDate;
        public string InvoiceDate
        {
            get { return _invoiceDate; }
            set { _invoiceDate = value; }
        }
        private float _subTotal;
        public float SubTotal
        {
            get { return _subTotal; }
            set { _subTotal = value; }
        }
        private float _vatPer;
        public float VatPerc
        {
            get { return _vatPer; }
            set { _vatPer = value; }
        }
        private float _vatAmount;
        public float VatAmount
        {
            get { return _vatAmount; }
            set { _vatAmount = value; }
        }
        private float _discountPer;
        public float DiscountPer
        {
            get { return _discountPer; }
            set { _discountPer = value; }
        }
        private float _discountAmount;
        public float DiscountAmount
        {
            get { return _discountAmount; }
            set { _discountAmount = value; }
        }
        private float _grandTotal;
        public float GrandTotal
        {
            get { return _grandTotal; }
            set { _grandTotal = value; }
        }
        private float _totalPayment;
        public float TotalPayment
        {
            get { return _totalPayment; }
            set { _totalPayment = value; }
        }
        private float _paymentDue;
        public float PaymentDue
        {
            get { return _paymentDue; }
            set { _paymentDue = value; }
        }
        private string _remarks;
        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }
    }
}
