using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemQuiche.Modelos;
using System.Data.SqlClient;
using System.Data;

namespace SystemQuiche.DAL
{
    public class CustomerDAL
    {
        public void Incluir(CustomerInformation cliente)
        {
            //Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                //nome da stored procedure
                cmd.CommandText = "insere_cliente";

                //parametros da stored procedure
                SqlParameter pCustomerId = new SqlParameter("@customerId", SqlDbType.Int);
                pCustomerId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pCustomerId);

                SqlParameter pCustomerName = new SqlParameter("@customerName", SqlDbType.NChar, 100);
                pCustomerName.Value = cliente.CustomerName;
                cmd.Parameters.Add(pCustomerName);

                SqlParameter pAddress = new SqlParameter("@address", SqlDbType.VarChar, 100);
                pAddress.Value = cliente.Address;
                cmd.Parameters.Add(pAddress);

                SqlParameter pCity = new SqlParameter("@city", SqlDbType.VarChar, 100);
                pCity.Value = cliente.City;
                cmd.Parameters.Add(pCity);

                SqlParameter pContactNo = new SqlParameter("@contactNo", SqlDbType.NChar, 15);
                pContactNo.Value = cliente.ContactNo;
                cmd.Parameters.Add(pContactNo);

                SqlParameter pContactNo1 = new SqlParameter("@contactNo1", SqlDbType.NChar, 15);
                pContactNo1.Value = cliente.ContactNo1;
                cmd.Parameters.Add(pContactNo1);

                SqlParameter pEmail = new SqlParameter("@email", SqlDbType.VarChar, 250);
                pEmail.Value = cliente.Email;
                cmd.Parameters.Add(pEmail);

                SqlParameter pNotes = new SqlParameter("@notes", SqlDbType.VarChar, 100);
                pNotes.Value = cliente.Notes;
                cmd.Parameters.Add(pNotes);

                cn.Open();
                cmd.ExecuteNonQuery();

                cliente.CustomerId = (Int32)cmd.Parameters["@customerName"].Value;

            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        // Alterar Cliente
        public void Alterar(CustomerInformation cliente)
        {
            //Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                //nome da stored procedure
                cmd.CommandText = "altera_cliente";

                //parametros da stored procedure
                SqlParameter pCustomerId = new SqlParameter("@customerId", SqlDbType.Int);
                pCustomerId.Value = cliente.CustomerId;
                cmd.Parameters.Add(pCustomerId);

                SqlParameter pCustomerName = new SqlParameter("@customerName", SqlDbType.NChar, 100);
                pCustomerName.Value = cliente.CustomerName;
                cmd.Parameters.Add(pCustomerName);

                SqlParameter pAddress = new SqlParameter("@address", SqlDbType.VarChar, 100);
                pAddress.Value = cliente.Address;
                cmd.Parameters.Add(pAddress);

                SqlParameter pCity = new SqlParameter("@city", SqlDbType.VarChar, 100);
                pCity.Value = cliente.City;
                cmd.Parameters.Add(pCity);

                SqlParameter pContactNo = new SqlParameter("@contactNo", SqlDbType.NChar, 15);
                pContactNo.Value = cliente.ContactNo;
                cmd.Parameters.Add(pContactNo);

                SqlParameter pContactNo1 = new SqlParameter("@contactNo1", SqlDbType.NChar, 15);
                pContactNo1.Value = cliente.ContactNo1;
                cmd.Parameters.Add(pContactNo1);

                SqlParameter pEmail = new SqlParameter("@email", SqlDbType.VarChar, 250);
                pEmail.Value = cliente.Email;
                cmd.Parameters.Add(pEmail);

                SqlParameter pNotes = new SqlParameter("@notes", SqlDbType.VarChar, 100);
                pNotes.Value = cliente.Notes;
                cmd.Parameters.Add(pNotes);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        // Exlcuir Cliente
        public void Excluir(int customerId)
        {
            //Conexao
            SqlConnection cn = new SqlConnection();
            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                //nome da stored procedure
                cmd.CommandText = "exclui_cliente";

                //paramentros da stored procedure
                SqlParameter pcustomerId = new SqlParameter("@customerId", SqlDbType.Int);
                pcustomerId.Value = customerId;
                cmd.Parameters.Add(pcustomerId);

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possivel excluir o cliente" + pcustomerId);
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQl Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable Listagem(string filtro)
        {
            SqlConnection cn = new SqlConnection();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //adapter
                da.SelectCommand = new SqlCommand();
                da.SelectCommand.CommandText = "seleciona_cliente";
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                //parametros da stored procedure
                SqlParameter pfiltro;
                pfiltro = da.SelectCommand.Parameters.Add("@filtro", SqlDbType.Text);
                pfiltro.Value = filtro;

                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
    }
}

