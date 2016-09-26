using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using SystemQuiche.Modelos;
using SystemQuiche.DAL;

namespace SystemQuiche.BLL
{
    public class ProductBLL
    {
                
        public void Incluir(ProductInformation produto)
        {
            //Nome do produto é obrigatorio
            if(produto.ProductName.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatorio.");
            }

            //O preço do produto não pode ser negativo
            if(produto.Price < 0)
            {
                throw new Exception("O preço do produto não pode ser negativo");
            }

            // Se tudo estiver OK, chama a rotina de gravação

            ProductDAL obj = new ProductDAL();
            obj.Incluir(produto);
        }

        public void Alterar(ProductInformation produto)
        {
            //Nome do produto é obrigatorio
            if (produto.ProductName.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatorio.");
            }

            //Preço do produto não pode ser negativo
            if(produto.Price < 0)
            {
                throw new Exception("O preço do produto não pode ser negativo.");
            }

            //Se tudo estiver OK, chama a rotina de alteração
            ProductDAL obj = new ProductDAL();
            obj.Alterar(produto);
        }

        public void Excluir(int ProductID)
        {
            ProductDAL obj = new ProductDAL();
            obj.Excluir(ProductID);
        }
    }
}
