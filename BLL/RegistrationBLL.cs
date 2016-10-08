using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class RegistrationBLL
    {
        IRegistrationRepositorio _registrationRepositorio;

        public RegistrationBLL()
        {
            try
            {
                //cria uma instância do repositorio registro
                _registrationRepositorio = new RegistrationRepositorio();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Registration> Get_Registration(string ID = null)
        {
            try
            {
                if (ID == null)
                {
                    //retorna todas as productSold
                    return _registrationRepositorio.GetTodos().ToList();
                }
                else
                {
                    //retorna uma determinada productSold pelo seu ID
                    return _registrationRepositorio.Get(r => r.UserName == ID).ToList();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AdicionarRepositorio(Registration reg)
        {
            try
            {
                _registrationRepositorio.Adicionar(reg);
                _registrationRepositorio.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Registration Localizar(int id)
        {
            try
            {
                return _registrationRepositorio.Find(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ExcluirRegistration(Registration reg)
        {
            try
            {
                _registrationRepositorio.Deletar(p => p == reg);
                _registrationRepositorio.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void AlterarRegistration(Registration reg)
        {
            try
            {
                _registrationRepositorio.Atualizar(reg);
                _registrationRepositorio.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
