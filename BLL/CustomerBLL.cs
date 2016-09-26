using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemQuiche.Modelos;
using SystemQuiche.DAL;
using System.Data;

namespace SystemQuiche.BLL
{
    public class CustomerBLL
    {
        public void Incluir(CustomerInformation cliente)
        {
            //O nome do cliente é obrigatório
            if (cliente.CustomerName.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatorio");
            }

            //E-mail é sempre em letras minusculas
            cliente.Email = cliente.Email.ToLower();

            //Se tudo está OK, chama a rotina de inserção
            CustomerDAL obj = new CustomerDAL();
            obj.Incluir(cliente);
        }

        public void Alterar(CustomerInformation cliente)
        {
            //O nome do cliente é obrigatório
            if (cliente.CustomerName.Trim().Length == 0)
            {
                throw new Exception("O nome do cliente é obrigatorio");
            }

            //E-mail é sempre em letras minusculas
            cliente.Email = cliente.Email.ToLower();

            //Se tudo está OK, chama a rotina de inserção
            CustomerDAL obj = new CustomerDAL();
            obj.Alterar(cliente);
        }

        public void Excluir(int customerId)
        {
            if(customerId < 1)
            {
                throw new Exception("Selecione um cliente antes de excluí-lo.");               
            }
            CustomerDAL obj = new CustomerDAL();
            obj.Excluir(customerId);
        }

        public DataTable Listagem(string filtro)
        {
            CustomerDAL obj = new CustomerDAL();
            return obj.Listagem(filtro);
        }
    }
    
}
