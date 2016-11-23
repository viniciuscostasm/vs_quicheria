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

        public List<Product> GetProdutosPorNome(string nm)
        {
            return _productRepositorio.Get(e => e.ProductName == nm).ToList();
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

        public String AdicionarProduto(string nm, double prc, int id)
        {
            pdt = new Product();
            pdt.ProductName = nm;
            pdt.Price = prc;
            pdt.CategoryID = id;
            try
            {

                _productRepositorio.Adicionar(pdt);
                _productRepositorio.Commit();
                return "Inserido com sucesso";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        public Product Localizar(int id)
        {
            try
            {
                return _productRepositorio.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public Product LocalizarPorNome(string nm)
        {
            return _productRepositorio.Get(p=> p.ProductName ==nm).SingleOrDefault();
        }

        public string ExcluirProduto(String nm)
        {
            try
            {
                _productRepositorio.Deletar(p => p.ProductName == nm);
                _productRepositorio.Commit();
                return "Excluído com sucesso";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }

        public string AlterarProduto(int id, string nm, double prc, int cat_id)
        {
            pdt = new Product();
            pdt.ProductID = id;
            pdt.ProductName = nm;
            pdt.Price = prc;
            pdt.CategoryID = cat_id;
            try
            {
                _productRepositorio.Atualizar(pdt);
                _productRepositorio.Commit();
                return "Alterado com sucesso";
            }
            catch (Exception ex)
            {
                return ex.Message;

            }
        }
    }
}

