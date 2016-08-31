using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemQuiche
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmRecuperarSenha recureparSenha = new frmRecuperarSenha();
            recureparSenha.txtEmail.Focus();
            recureparSenha.Show(); 
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            frmAlterarSenha alterarSenha = new frmAlterarSenha();
            alterarSenha.Show();
            alterarSenha.txtNomeUsuario.Text = "";
            alterarSenha.txtNovaSenha.Text = "";
            alterarSenha.txtOldSenha.Text = "";
            alterarSenha.txtConfirmaSenha.Text = "";
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            txtNomeUsuario.Focus();
        }
    }
}
