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


namespace SystemQuiche{
    public partial class frmProdutos : Form
    {

        ProductBLL pdt = new ProductBLL();
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {

        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rMS_DBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.CadastroDataSet.Product);
            // TODO: This line of code loads data into the 'rMS_DBDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.CadastroDataSet.Category);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            pdt.AdicionarProduto(txtNomeProduto.Text.ToUpper(), Convert.ToDouble(txtPreco.Text), 2084);
            MessageBox.Show("Produto inserido com sucesso", "My Application",
                   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtNomeProduto.Clear();
            txtPreco.Clear();
            this.productTableAdapter.Fill(this.CadastroDataSet.Product);
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.txtNomeProduto.Text = (dataGridView.CurrentRow.Cells[1].Value.ToString());
            this.txtPreco.Text =  (dataGridView.CurrentRow.Cells[3].Value.ToString());
            this.btnDeletar.Enabled = true;
            this.btnAtualizar.Enabled = true;
            
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmar exclusão? ", "My Application",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            pdt.ExcluirProduto(txtNomeProduto.Text);
            this.productTableAdapter.Fill(this.CadastroDataSet.Product);
            MessageBox.Show("Produto excluído com sucesso", "My Application",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtNomeProduto.Clear();
            txtPreco.Clear();
            this.productTableAdapter.Update(this.CadastroDataSet.Product);
        }
    }
}
