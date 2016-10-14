using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BLL;
using Model;


namespace SystemQuiche
{
    public partial class frmLogin : Form
    {

        ConnectionString cs = new ConnectionString();
        DataTable dt = new DataTable();


        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            txtNomeUsuario.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtNomeUsuario.Text == "")
            {
                MessageBox.Show("Informe o  Usuário", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeUsuario.Focus();
                return;
            }
            if (txtSenha.Text == "")
            {
                MessageBox.Show("Informe a senha", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return;
            }
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConn);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("SELECT Username,password FROM Registration WHERE Username = @username AND password = @UserPassword", myConnection);
                SqlParameter uName = new SqlParameter("@username", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@UserPassword", SqlDbType.VarChar);
                uName.Value = txtNomeUsuario.Text;
                uPassword.Value = txtSenha.Text;
                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                if (myReader.Read() == true)
                {
                    int i;
                    progressBar1.Visible = true;
                    progressBar1.Maximum = 5000;
                    progressBar1.Minimum = 0;
                    progressBar1.Value = 4;
                    progressBar1.Step = 1;

                    for (i = 0; i <= 5000; i++)
                    {
                        progressBar1.PerformStep();
                    }

                    this.Hide();
                    MDIPrincipal frm = new MDIPrincipal();
                    frm.Show();
                    frm.lblUsuario.Text = txtNomeUsuario.Text;

                }


                else
                {
                    MessageBox.Show("Login Falhou..Tente novamente !", "Login Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtNomeUsuario.Clear();
                    txtSenha.Clear();
                    txtNomeUsuario.Focus();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    

    private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmAlterarSenha frm = new frmAlterarSenha();
            frm.Show();
            frm.txtNomeUsuario.Text = "";
            frm.txtNovaSenha.Text = "";
            frm.txtOldSenha.Text = "";
            frm.txtConfirmaSenha.Text = "";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRecuperarSenha frm = new frmRecuperarSenha();
            frm.txtEmail.Focus();
            frm.Show();
        }
    }
}


