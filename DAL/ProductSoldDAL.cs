using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SystemQuiche.Modelos;

namespace SystemQuiche.DAL
{
    public class ProductSoldDAL
    {
        public void Incluir(ProductSoldInformation venda)
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
                cmd.CommandText = "insere_venda";

                //parametros da stored procedure
                SqlParameter pId = new SqlParameter("@Id", SqlDbType.Int);
                pId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pId);

                SqlParameter pInvoiceNo = new SqlParameter("invoiceNo", SqlDbType.NChar, 100);
                pInvoiceNo.Value = venda.InvoiceNo;
                cmd.Parameters.Add(pInvoiceNo);

                SqlParameter pProductID = new SqlParameter("@productID", SqlDbType.Int);
                pProductID.Value = venda.ProductID;
                cmd.Parameters.Add(pProductID);

                SqlParameter pProductName = new SqlParameter("@productName", SqlDbType.VarChar, 100);
                pProductName.Value = venda.ProductName;
                cmd.Parameters.Add(pProductName);

                SqlParameter pPrice = new SqlParameter("@price", SqlDbType.Float);
                pPrice.Value = venda.Price;
                cmd.Parameters.Add(pPrice);

                SqlParameter pQuantity = new SqlParameter("@quantity", SqlDbType.Int);
                pQuantity.Value = venda.Quantity;
                cmd.Parameters.Add(pQuantity);

                SqlParameter pTotalAmount = new SqlParameter("@totalAmount", SqlDbType.Float);
                pTotalAmount.Value = venda.TotalAmount;
                cmd.Parameters.Add(pTotalAmount);

                cn.Open();
                cmd.ExecuteNonQuery();

                venda.Id = (Int32)cmd.Parameters["@Id"].Value;

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

        // Alterar Venda
        public void Alterar(ProductSoldInformation venda)
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
                cmd.CommandText = "altera_venda";

                //parametros da stored procedure
                SqlParameter pId = new SqlParameter("@Id", SqlDbType.Int);
                pId.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pId);

                SqlParameter pInvoiceNo = new SqlParameter("invoiceNo", SqlDbType.NChar, 100);
                pInvoiceNo.Value = venda.InvoiceNo;
                cmd.Parameters.Add(pInvoiceNo);

                SqlParameter pProductID = new SqlParameter("@productID", SqlDbType.Int);
                pProductID.Value = venda.ProductID;
                cmd.Parameters.Add(pProductID);

                SqlParameter pProductName = new SqlParameter("@productName", SqlDbType.VarChar, 100);
                pProductName.Value = venda.ProductName;
                cmd.Parameters.Add(pProductName);

                SqlParameter pPrice = new SqlParameter("@price", SqlDbType.Float);
                pPrice.Value = venda.Price;
                cmd.Parameters.Add(pPrice);

                SqlParameter pQuantity = new SqlParameter("@quantity", SqlDbType.Int);
                pQuantity.Value = venda.Quantity;
                cmd.Parameters.Add(pQuantity);

                SqlParameter pTotalAmount = new SqlParameter("@totalAmount", SqlDbType.Float);
                pTotalAmount.Value = venda.TotalAmount;
                cmd.Parameters.Add(pTotalAmount);

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

        // Exlcuir Venda
        public void Excluir(int id)
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
                cmd.CommandText = "exclui_venda";

                //paramentros da stored procedure
                SqlParameter pId = new SqlParameter("@id", SqlDbType.Int);
                pId.Value = id;
                cmd.Parameters.Add(pId);

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possivel excluir a venda" + pId);
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
                da.SelectCommand.CommandText = "seleciona_venda";
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

  