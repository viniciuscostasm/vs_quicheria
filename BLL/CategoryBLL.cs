using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    // Na classe CategoryBLL implementei método para realizar as operações CRUD
    // e selecionar dados usando o Repositorio criado na camada DAL. 
    // Eu implementei um tratamento de exceção nesta classe.

    public class CategoryBLL
    {
        ICategoryRepositorio _categoryRepositorio;

        public CategoryBLL()
        {
            try
            {
                //cria uma instância do repositorio categoria
                _categoryRepositorio = new CategoryRepositorio();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Category> Get_CategoriaInfo(int ID = -1)
        {
            try
            {
                if (ID == -1)
                {
                    //retorna todas as categorias
                    return _categoryRepositorio.GetTodos().ToList();
                }
                else
                {
                    //retorna uma determinada categoria pelo seu ID
                    return _categoryRepositorio.Get(p => p.Id == ID).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AdicionarCategoria(Category cat)
        {
            try
            {
                _categoryRepositorio.Adicionar(cat);
                _categoryRepositorio.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Category Localizar(int id)
        {
            try
            {
                return _categoryRepositorio.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirCategoria(Category cat)
        {
            try
            {
                _categoryRepositorio.Deletar(c => c == cat);
                _categoryRepositorio.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarCategoria(Category cat)
        {
            try
            {
                _categoryRepositorio.Atualizar(cat);
                _categoryRepositorio.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
