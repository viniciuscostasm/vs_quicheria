using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class CustomerBLL
    {
        ICustomerRepositorio _customerRepositorio;

        public CustomerBLL()
        {
            try
            {
                //cria uma instância do repositorio categoria
                _customerRepositorio = new CustomerRepositorio();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Customer> Get_CustomerInfo(string ID = null)
        {
            try
            {
                if (ID == null)
                {
                    //retorna todas os clientes
                    return _customerRepositorio.GetTodos().ToList();
                }
                else
                {
                    //retorna uma determinado cliente pelo seu ID
                    return _customerRepositorio.Get(c => c.CustomerId == ID).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AdicionarCliente(Customer cus)
        {
            try
            {
                _customerRepositorio.Adicionar(cus);
                _customerRepositorio.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Customer Localizar(int id)
        {
            try
            {
                return _customerRepositorio.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirCategoria(Customer cus)
        {
            try
            {
                _customerRepositorio.Deletar(c => c == cus);
                _customerRepositorio.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarCategoria(Customer cus)
        {
            try
            {
                _customerRepositorio.Atualizar(cus);
                _customerRepositorio.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
