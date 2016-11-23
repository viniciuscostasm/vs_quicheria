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
            // TODO: This line of code loads data into the 'cadastroDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.cadastroDataSet.Product);
            // TODO: This line of code loads data into the 'cadastroDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.cadastroDataSet.Category);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            var msg = pdt.AdicionarProduto(txtNomeProduto.Text.ToUpper(),
                                           Convert.ToDouble(txtPreco.Text), 
                                           Convert.ToInt32(cmbCategoria.SelectedValue));
            MessageBox.Show(msg, "System Quiche",
                   MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtNomeProduto.Clear();
            txtPreco.Clear();
            this.productTableAdapter.Fill(this.cadastroDataSet.Product);
        }



        private void btnDeletar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Confirmar exclusão? ", "System Quiche",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            var msg = pdt.ExcluirProduto(txtNomeProduto.Text);
            MessageBox.Show(msg, "System Quiche",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtNomeProduto.Clear();
            txtPreco.Clear();
            this.productTableAdapter.Fill(this.cadastroDataSet.Product);
        }

        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         
            this.txtNomeProduto.Text = (dataGridView.CurrentRow.Cells[1].Value.ToString());
            this.cmbCategoria.SelectedValue = (dataGridView.CurrentRow.Cells[2].Value.ToString());
            this.cmbCategoria.SelectedValue = (dataGridView.CurrentRow.Cells[2].Value.ToString());
            this.txtPreco.Text = (Convert.ToDouble(dataGridView.CurrentRow.Cells[3].Value.ToString())*100).ToString();
            this.btnDeletar.Enabled = true;
            this.btnAtualizar.Enabled = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja realmente alterar o produto?", 
                "System Quiche",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
           var msg = pdt.AlterarProduto(Convert.ToInt32(dataGridView.CurrentRow.Cells[0].Value.ToString()),
                               txtNomeProduto.Text,
                               Convert.ToDouble(txtPreco.Text),
                               Convert.ToInt32(cmbCategoria.SelectedValue));
            this.productTableAdapter.Fill(this.cadastroDataSet.Product);

        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            Program.Moeda(ref txtPreco);
        }
    }
}
