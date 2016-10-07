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

namespace SystemQuiche
{
    public partial class frmLogin : Form
    {
        

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


