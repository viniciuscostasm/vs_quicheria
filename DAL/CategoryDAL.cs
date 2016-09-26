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
    public class CategoryDAL
    {
        public void Incluir(CategoryInformation categoria)
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
                cmd.CommandText = "insere_categoria";

                //parametros da stored procedure
                SqlParameter pId = new SqlParameter("@Id", SqlDbType.Int);
                pId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pId);

                SqlParameter pCategoryName = new SqlParameter("@categoryName", SqlDbType.VarChar, 100);
                pCategoryName.Value = categoria.CategoryName;
                cmd.Parameters.Add(pCategoryName);

                cn.Open();
                cmd.ExecuteNonQuery();

                categoria.Id = (Int32)cmd.Parameters["@categoryName"].Value;

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

        // Alterar Categoria
        public void Alterar(CategoryInformation categoria)
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
                cmd.CommandText = "altera_categoria";

                //parametros da stored procedure
                SqlParameter pId = new SqlParameter("@Id", SqlDbType.Int);
                pId.Value = categoria.Id;
                cmd.Parameters.Add(pId);

                SqlParameter pCategoryName = new SqlParameter("@categoryName", SqlDbType.VarChar, 100);
                pCategoryName.Value = categoria.CategoryName;
                cmd.Parameters.Add(pCategoryName);

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

        // Exlcuir Categoria
        public void Excluir(int Id)
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
                cmd.CommandText = "exclui_categoria";

                //paramentros da stored procedure
                SqlParameter pId = new SqlParameter("@Id", SqlDbType.Int);
                pId.Value = Id;
                cmd.Parameters.Add(pId);

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possivel excluir a categoria" + pId);
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
                da.SelectCommand.CommandText = "seleciona_categoria";
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