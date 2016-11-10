using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemQuiche{
    public partial class frmAlterarSenha : Form
    {
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        private void frmAlterarSenha_Load(object sender, EventArgs e)
        {

        }

        private void frmAlterarSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmLogin frm = new frmLogin();
            frm.txtNomeUsuario.Text = "";
            frm.txtSenha.Text = "";
            frm.progressBar1.Visible = false;
            frm.txtNomeUsuario.Focus();
            frm.Show();
        }
    }
}
