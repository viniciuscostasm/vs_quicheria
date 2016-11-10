using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Model;

namespace SystemQuiche
{
    public partial class frmProdutos : Form
    {
        ProductBLL pdtBLL = new ProductBLL();

        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'CadastroDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.CadastroDataSet.Product);
            // TODO: This line of code loads data into the 'CadastroDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.CadastroDataSet.Category);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            pdtBLL.AdicionarProduto(txtNomeProduto.Text,Convert.ToDouble(txtPreco.Text), 2072);
                MessageBox.Show("Produto inserido com sucesso", "My Application",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtNomeProduto.Clear();
            txtPreco.Clear();
            txtCategoriaID.Refresh();
            this.productTableAdapter.Fill(this.CadastroDataSet.Product);

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Confirmar exclusão? ", "My Application",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            pdtBLL.ExcluirProduto(txtNomeProduto.Text);
            this.productTableAdapter.Fill(this.CadastroDataSet.Product);
            MessageBox.Show("Produto excluído com sucesso", "My Application",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtNomeProduto.Clear();
            txtPreco.Clear();
            txtCategoriaID.Refresh();


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //this.Hide();
            
            this.txtNomeProduto.Text = (dataGridView.CurrentRow.Cells[1].Value.ToString());
            this.btnDeletar.Enabled = true;
            this.btnAtualizar.Enabled = true;
        }
    }
}
