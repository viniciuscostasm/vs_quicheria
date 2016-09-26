using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SystemQuiche.Modelos;
using System.Data.SqlClient;

namespace SystemQuiche.DAL
{
    public class ProductDAL
    {
        public void Incluir(ProductInformation produto)
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
                cmd.CommandText = "insere_produto";

                //parametros da stored procedure
                SqlParameter pProductID = new SqlParameter("@productID", SqlDbType.Int);
                pProductID.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pProductID);

                SqlParameter pProductName = new SqlParameter("@productName", SqlDbType.VarChar, 100);
                pProductName.Value = produto.ProductName;
                cmd.Parameters.Add(pProductName);

                SqlParameter pCategoryID = new SqlParameter("@categoryID", SqlDbType.Int);
                pCategoryID.Value = produto.CategoryID;
                cmd.Parameters.Add(pCategoryID);

                SqlParameter pPrice = new SqlParameter("@price", SqlDbType.Float);
                pPrice.Value = produto.Price;
                cmd.Parameters.Add(pPrice);

                cn.Open();
                cmd.ExecuteNonQuery();

                produto.ProductID = (Int32)cmd.Parameters["@ProductName"].Value;

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

        // Alterar produto
        public void Alterar(ProductInformation produto)
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
                cmd.CommandText = "altera_produto";

                //parametros da stored procedure
                SqlParameter pProductID = new SqlParameter("@productID", SqlDbType.Int);
                pProductID.Value = produto.ProductID;
                cmd.Parameters.Add(pProductID);

                SqlParameter pProductName = new SqlParameter("@productName", SqlDbType.VarChar, 100);
                pProductName.Value = produto.ProductName;
                cmd.Parameters.Add(pProductName);

                SqlParameter pCategoryID = new SqlParameter("@categoryID", SqlDbType.Int);
                pCategoryID.Value = produto.CategoryID;
                cmd.Parameters.Add(pCategoryID);

                SqlParameter pPrice = new SqlParameter("@price", SqlDbType.Float);
                pPrice.Value = produto.Price;
                cmd.Parameters.Add(pPrice);

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

        // Exlcuir Produto
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
                cmd.CommandText = "exclui_produto";

                //paramentros da stored procedure
                SqlParameter pProductID = new SqlParameter("@productID", SqlDbType.Int);
                pProductID.Value = customerId;
                cmd.Parameters.Add(pProductID);

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possivel excluir o produto" + pProductID);
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
                da.SelectCommand.CommandText = "seleciona_produto";
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

  