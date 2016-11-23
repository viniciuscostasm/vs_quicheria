using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class Invoice_InfoBLL
    {
        IInvoice_InfoRepositorio _invoice_InfoRepositorio;
        Invoice_Info inv;
        public Invoice_InfoBLL()
        {
            try
            {
                //cria uma instância do repositorio venda
                _invoice_InfoRepositorio = new Invoice_InfoRepositorio();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Invoice_Info> Get_Invoice_Info(string ID = null)
        {
            try
            {
                if (ID == null)
                {
                    //retorna todas as venda
                    return _invoice_InfoRepositorio.GetTodos().ToList();
                }
                else
                {
                    //retorna uma determinada venda pelo seu ID
                    return _invoice_InfoRepositorio.Get(p => p.InvoiceNo == ID).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        
        public string AdicionarInvoice_Info(string InvoiceNo, 
                                            string InvoiceDate, 
                                            double SubTotal,
                                            double VATPer,
                                            double VATAmount,
                                            double DiscountPer,
                                            double DiscountAmount,
                                            double GrandTotal,
                                            double TotalPayment,
                                            double PaymentDue,
                                            string Remarks)
        {
            inv = new Invoice_Info();
            inv.InvoiceNo = InvoiceNo;
            inv.InvoiceDate = InvoiceDate;
            inv.SubTotal = SubTotal;
            inv.VATPer = VATPer;
            inv.VATAmount = VATAmount;
            inv.DiscountPer = DiscountPer;
            inv.DiscountAmount = DiscountAmount;
            inv.GrandTotal = GrandTotal;
            inv.TotalPayment = TotalPayment;
            inv.PaymentDue = PaymentDue;
            inv.Remarks = Remarks;
            
            try
            {
                _invoice_InfoRepositorio.Adicionar(inv);
                _invoice_InfoRepositorio.Commit();
                return "Sucesso";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public Invoice_Info Localizar(int id)
        {
            try
            {
                return _invoice_InfoRepositorio.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Invoice_Info LocalizarPorNumero(string InvoiceNo)
        {
            return _invoice_InfoRepositorio.Get(i => i.InvoiceNo == InvoiceNo).SingleOrDefault();
        }

        public void ExcluirCategoria(Invoice_Info inv)
        {
            try
            {
                _invoice_InfoRepositorio.Deletar(c => c == inv);
                _invoice_InfoRepositorio.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarInvoice_Info(Invoice_Info inv)
        {
            try
            {
                _invoice_InfoRepositorio.Atualizar(inv);
                _invoice_InfoRepositorio.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
