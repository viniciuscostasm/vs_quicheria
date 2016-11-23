using BLL;
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
    public partial class frmCategoria : Form
    {
        CategoryBLL catBLL = new CategoryBLL();
        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnObterDados_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCategoriaRecord frm = new frmCategoriaRecord();
            frm.Show();
            //frm.ObterDados();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtNomeCategoria.Text = "";
            btnSalvar.Enabled = true;
            btnDeletar.Enabled = false;
            btnAtualizar.Enabled = false;
            txtNomeCategoria.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            
                MessageBox.Show(catBLL.AdicionarCategoria(txtNomeCategoria.Text.ToUpper()), 
                    "My Application", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtNomeCategoria.Clear();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmar exclusão? ", "My Application",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                MessageBox.Show(catBLL.ExcluirCategoria(txtNomeCategoria.Text), "My Application",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtNomeCategoria.Clear();
        }
    }
}
