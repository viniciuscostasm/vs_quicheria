using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{

    // Na classe ProductBLL implementei método para realizar as operações CRUD 
    // e selecionar dados usando o Repositorio criado na camada DAL. 
    // Eu não implementei um tratamento de exceção nesta classe, farei isso na classe CategoryBLL.

    public class ProductBLL
    {
        IProductRepositorio _productRepositorio;
        Product pdt;
        public ProductBLL()
        {
            //cria uma instância do repositorio Produto
            _productRepositorio = new ProductRepositorio();
        }

        public List<Product> GetProdutosPorCategoria(int categoryID)
        {
            return _productRepositorio.Get(e => e.CategoryID == categoryID).ToList();
        }

        public List<Product> Get_CategoriaInfo(int ProductID = -1)
        {
            if (ProductID == -1)
            {
                //retorna todos os produtos
                return _productRepositorio.GetTodos().ToList();
            }
            else
            {
                //retorna um determinado produto pelo seu ID
                return _productRepositorio.Get(p => p.ProductID == ProductID).ToList();
            }
        }

        public void AdicionarProduto(string nm, double prc, int id)
        {
            pdt = new Product();
            pdt.ProductName = nm;
            pdt.Price = prc;
            pdt.CategoryID = id;
            try
            {
                
                _productRepositorio.Adicionar(pdt);
                _productRepositorio.Commit();
                //return true;
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public Product Localizar(int id)
        {
            return _productRepositorio.Find(id);
        }

        public void ExcluirProduto(String nm)
        {
            _productRepositorio.Deletar(p => p.ProductName == nm);
            _productRepositorio.Commit();           
        }

        public void AlterarProduto(Product prod)
        {
            _productRepositorio.Atualizar(prod);
            _productRepositorio.Commit();
        }
    }
}

