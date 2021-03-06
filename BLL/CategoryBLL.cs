﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    // Na classe CategoryBLL implementei método para realizar as operações CRUD
    // e selecionar dados usando o Repositorio criado na camada DAL. 
    // Eu implementei um tratamento de exceção nesta classe.

    public class CategoryBLL
    {
        ICategoryRepositorio _categoryRepositorio;
        Category cat;
        public CategoryBLL()
        {
            try
            {
                //cria uma instância do repositorio categoria
                _categoryRepositorio = new CategoryRepositorio();
                cat = new Category();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Model.Category> Get_CategoriaInfo(int ID = -1)
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
                    return _categoryRepositorio.Get(c => c.Id == ID).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Model.Category> GetAll()
        {
            try
            {
               
                    //retorna todas as categorias
                    return _categoryRepositorio.GetTodos().ToList();
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string AdicionarCategoria(string nm)
        {
            try
            {
                cat.CategoryName = nm;
                _categoryRepositorio.Adicionar(cat);
                _categoryRepositorio.Commit();
                return "Categoria cadastrada com sucesso!";
            }
            catch (Exception ex)
            {
                return ex.Message;

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

        public string ExcluirCategoria(string nm)
        {
            try
            {
                _categoryRepositorio.Deletar(c => c.CategoryName == nm);
                _categoryRepositorio.Commit();
                return "Excluído com sucesso";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void AlterarCategoria(Model.Category cat)
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
