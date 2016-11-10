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
        Registration reg;
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
        public void AdicionarRegistration(string usuario, string tipo, string senha, string nome, string contato, string email)
        {

            try
            {
                reg = new Registration();
                reg.UserName = usuario;
                reg.UserType = tipo;
                reg.Password = senha;
                reg.Name = nome;
                reg.ContactNo = contato;
                reg.Email = email;
                _registrationRepositorio.Adicionar(reg);
                _registrationRepositorio.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Registration Localizar(string user)
        {
            try
            {
                return _registrationRepositorio.Find(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Boolean Logar(string login, string senha)
        {
            
            try
            {
                var dbo = new CadastroEntities();
                var user = dbo.Registration.FirstOrDefault(u => u.UserName == login && u.Password == senha);
                
                if (user == null)
                {
                    return false;
                }

                    return true;
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
