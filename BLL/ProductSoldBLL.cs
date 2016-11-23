using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class ProductSoldBLL
    {
        IProductSoldRepositorio _productSoldRepositorio;
        ProductSold pds;

        public ProductSoldBLL()
        {
            try
            {
                //cria uma instância do repositorio productSold
                _productSoldRepositorio = new ProductSoldRepositorio();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<ProductSold> Get_ProductSold(int ID = -1)
        {
            try
            {
                if (ID == -1)
                {
                    //retorna todas as productSold
                    return _productSoldRepositorio.GetTodos().ToList();
                }
                else
                {
                    //retorna uma determinada productSold pelo seu ID
                    return _productSoldRepositorio.Get(p => p.Id == ID).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string AdicionarProductSold(string invoiceNo, int pID, string pNome, double preco, int qntd, double valor)
        {
            try
            {
                pds = new ProductSold();
                pds.InvoiceNo = invoiceNo;
                pds.ProductID = pID;
                pds.ProductName = pNome;
                pds.Price = preco;
                pds.Quantity = qntd;
                pds.TotalAmount = valor;
                _productSoldRepositorio.Adicionar(pds);
                _productSoldRepositorio.Commit();
                return "Compra efetuada com sucesso!";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public ProductSold Localizar(int id)
        {
            try
            {
                return _productSoldRepositorio.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public ProductSold LocalizarPorNome(string nm)
        {
            try
            {
                return _productSoldRepositorio.Find(nm);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluiProductSold(ProductSold pds)
        {
            try
            {
                _productSoldRepositorio.Deletar(p => p == pds);
                _productSoldRepositorio.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarProductSold(ProductSold pds)
        {
            try
            {
                _productSoldRepositorio.Atualizar(pds);
                _productSoldRepositorio.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
