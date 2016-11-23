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
using System.Security.Cryptography;
using BLL;

namespace SystemQuiche
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
           
        }
        ProductBLL pd = new ProductBLL();
        ProductSoldBLL ps;
        Invoice_InfoBLL invoice;
        
        double soma = 0;
        public void Calcular()
        {
            if (txtTaxPer.Text != "")
            {
                txtTaxAmt.Text = Convert.ToDouble((Convert.ToDouble(txtSubTotal.Text) * Convert.ToDouble(txtTaxPer.Text) / 100)).ToString();
            }
            else
            {
                txtTaxAmt.Text = "0";
            }
            if (txtDescontoPer.Text != "")
            {
                txtDescontoAmount.Text = Convert.ToDouble(((Convert.ToDouble(txtSubTotal.Text) + Convert.ToDouble(txtTaxAmt.Text)) * Convert.ToDouble(txtDescontoPer.Text) / 100)).ToString();
            }
            else
            {
                txtDescontoAmount.Text = "0";
            }
            double val1;
            double val2;
            double val3;
            double val4;
            double val5;
            double.TryParse(txtTaxAmt.Text, out val1);
            double.TryParse(txtSubTotal.Text, out val2);
            double.TryParse(txtDescontoAmount.Text, out val3);
            double.TryParse(txtTotal.Text, out val4);
            double.TryParse(txtTotalPago.Text, out val5);
            val4 = val1 + val2 - val3;
            txtTotal.Text = val4.ToString("N2");
            double I = (val5 - val4);
            txtValorDevido.Text = I.ToString("N2");
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.cadastroDataSet.Product);
           
        }

        private void txtQtdVenda_TextChanged(object sender, EventArgs e)
        {
            int val1 = 0;
            int val2 = 0;
            var produto = pd.Localizar(Convert.ToInt32(cmbNomeProduto.SelectedValue));
            int.TryParse(produto.Price.ToString(), out val1);
            int.TryParse(txtQtdVenda.Text, out val2);
            int I = (val1 * val2);
            txtValorTotal.Text = I.ToString();
            txtPreco.Text = produto.Price.ToString();
        }

        private void btnIncluirCarrinho_Click(object sender, EventArgs e)
        {

            txtTaxPer.Enabled = true;
            txtDescontoAmount.Enabled = true;
            txtDescontoPer.Enabled = true;
            txtSubTotal.Enabled = true;
            txtTaxAmt.Enabled = true;
            txtTotalPago.Enabled = true;
            txtValorDevido.Enabled = true;
            txtTotal.Enabled = true;
            try//
            {
                if (cmbNomeProduto.Text == "")
                {
                    MessageBox.Show("Selecione o nome do produto", "Erro2", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtQtdVenda.Text == "")
                {
                    MessageBox.Show("Informe a quantidade", "Erro3", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQtdVenda.Focus();
                    return;
                }
                int QtdVenda = Convert.ToInt32(txtQtdVenda.Text);
                if (QtdVenda == 0)
                {
                    MessageBox.Show("Quantidade não pode ser zero", "Erro4", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQtdVenda.Focus();
                    return;
                }

                var produto = pd.Localizar(Convert.ToInt32(cmbNomeProduto.SelectedValue));
                ListViewItem lst = new ListViewItem();
                lst.SubItems.Add(produto.ProductID.ToString());
                lst.SubItems.Add(produto.ProductName);
                lst.SubItems.Add(produto.Price.ToString("N2"));
                lst.SubItems.Add(txtQtdVenda.Text);
                lst.SubItems.Add(txtValorTotal.Text.ToString());
                listView1.Items.Add(lst);
                soma += (Convert.ToDouble(produto.Price) * Convert.ToDouble(txtQtdVenda.Text));
                txtSubTotal.Text = soma.ToString("N2");
                cmbNomeProduto.Text = "";
                txtProdutoID.Text = "";
                txtPreco.Text = "";
                txtQtdVenda.Text = "";
                txtValorTotal.Text = "";

                for (int j = 0; j <= listView1.Items.Count - 1; j++)
                {
                    if (listView1.Items[j].SubItems[1].Text == txtProdutoID.Text)
                    {
                        listView1.Items[j].SubItems[1].Text = txtProdutoID.Text;
                        listView1.Items[j].SubItems[2].Text = cmbNomeProduto.Text;
                        listView1.Items[j].SubItems[3].Text = txtPreco.Text;
                        listView1.Items[j].SubItems[4].Text = (Convert.ToInt32(listView1.Items[j].SubItems[4].Text) + Convert.ToInt32(txtQtdVenda.Text)).ToString();
                        listView1.Items[j].SubItems[5].Text = (Convert.ToDouble(listView1.Items[j].SubItems[5].Text) + Convert.ToDouble(txtValorTotal.Text)).ToString();
                        soma += produto.Price;
                        txtSubTotal.Text = soma.ToString("N2");
                        
                        cmbNomeProduto.Text = "";
                        txtProdutoID.Text = "";
                        txtPreco.Text = "";
                        txtQtdVenda.Text = "";
                        txtValorTotal.Text = "";

                    }
                }

                ListViewItem lst1 = new ListViewItem();

                lst1.SubItems.Add(txtProdutoID.Text);
                lst1.SubItems.Add(cmbNomeProduto.Text);
                lst1.SubItems.Add(txtPreco.Text);
                lst1.SubItems.Add(txtQtdVenda.Text);
                lst1.SubItems.Add(txtValorTotal.Text);
                listView1.Items.Add(lst1);

                cmbNomeProduto.Text = "";
                txtProdutoID.Text = "";
                txtPreco.Text = "";
                txtQtdVenda.Text = "";
                txtValorTotal.Text = "";
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error5", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTaxPer_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Program.Moeda(ref txtTaxPer);
                if (string.IsNullOrEmpty(txtTaxPer.Text))
                {
                    txtTaxAmt.Text = "";
                    txtTotal.Text = "";
                    return;
                }
                Calcular();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error6", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnRemover.Enabled = true;
        }

        private void Reset()
        {
            txtNumPedido.Text = "";
            dtpDataPedido.Text = DateTime.Today.ToString();

            cmbNomeProduto.Text = "";
            txtProdutoID.Text = "";
            txtPreco.Text = "";

            txtQtdVenda.Text = "";
            txtValorTotal.Text = "";
            listView1.Items.Clear();
            txtDescontoAmount.Text = "";
            txtDescontoPer.Text = "";

            txtSubTotal.Text = "";
            txtTaxPer.Text = "";
            txtTaxAmt.Text = "";
            txtTotal.Text = "";
            txtTotalPago.Text = "";
            txtValorDevido.Text = "";
            txtObservacoes.Text = "";
            btnSalvar.Enabled = true;
            btnDeletar.Enabled = false;
            btnAtualiar.Enabled = false;
            btnRemover.Enabled = false;
            btnPrint.Enabled = false;
            listView1.Enabled = true;
            btnIncluirCarrinho.Enabled = true;
                        
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtTotalPago_TextChanged(object sender, EventArgs e)
        {
            Program.Moeda(ref txtTotalPago);
            txtValorDevido.Text = (Convert.ToDouble(txtTotalPago.Text) - Convert.ToDouble(txtValorTotal.Text)).ToString();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
            timer1.Enabled = false;
        }

        private void btnProcurarPedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmVendasRecord frm = new frmVendasRecord();
            frm.dataGridView1.DataSource = null;
            frm.dtpInvoiceDateFrom.Text = DateTime.Today.ToString();
            frm.dtpInvoiceDateTo.Text = DateTime.Today.ToString();
            frm.groupBox3.Visible = false;
            frm.dateTimePicker1.Text = DateTime.Today.ToString();
            frm.dateTimePicker2.Text = DateTime.Today.ToString();
            frm.dataGridView2.DataSource = null;
            frm.groupBox6.Visible = false;
            frm.Show();
        }

        private void txtQtdVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTotalPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtTaxPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            // permite 0-9, retrocesso, e decimal
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtDescontoPer_TextChanged(object sender, EventArgs e)
        {
            Program.Moeda(ref txtDescontoPer);
            Calcular();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ps = new ProductSoldBLL();
            invoice = new Invoice_InfoBLL();
            var InvoiceNo = "OD- " + (DateTime.Now.Ticks / 10000000).ToString();
            if (txtTaxPer.Text == "")
                txtTaxPer.Text = Convert.ToDouble("0").ToString();
            if (txtDescontoPer.Text == "")
                txtDescontoPer.Text = Convert.ToDouble("0").ToString();
            if (txtTotalPago.Text == "")
                txtTotalPago.Text = Convert.ToDouble("0").ToString();
            var msg = invoice.AdicionarInvoice_Info(InvoiceNo,
                                                    DateTime.Now.ToString("d"),
                                                    Convert.ToDouble(txtSubTotal.Text),
                                                    Convert.ToDouble(txtTaxPer.Text),
                                                    Convert.ToDouble(txtTaxAmt.Text),
                                                    Convert.ToDouble(txtDescontoPer.Text),
                                                    Convert.ToDouble(txtDescontoAmount.Text),
                                                    Convert.ToDouble(txtTotal.Text),
                                                    Convert.ToDouble(txtTotalPago.Text),
                                                    Convert.ToDouble(txtValorDevido.Text),
                                                    txtObservacoes.Text);
            MessageBox.Show(msg, listView1.Items[0].SubItems[2].Text,
                  MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            var x = invoice.LocalizarPorNumero(InvoiceNo);

            for (int j = 0; j <= listView1.Items.Count - 1; j++)
            {
                ps.AdicionarProductSold(x.InvoiceNo,
                Convert.ToInt32(listView1.Items[j].SubItems[1].Text),
                listView1.Items[j].SubItems[2].Text,
                Convert.ToDouble(listView1.Items[j].SubItems[3].Text),
                Convert.ToInt32(listView1.Items[j].SubItems[4].Text),
                Convert.ToDouble(listView1.Items[j].SubItems[5].Text));
            }

        }

        private string CalcularTxtValorTotal()
        {
            return txtValorTotal.Text = (Convert.ToDouble(txtQtdVenda.Text) * Convert.ToDouble(txtPreco.Text)).ToString("N2");
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {

            txtValorTotal.Text = CalcularTxtValorTotal();
        }

        private void txtSubTotal_TextChanged(object sender, EventArgs e)
        {
            Program.Moeda(ref txtSubTotal);
            txtTotal.Text = txtSubTotal.Text;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {

        }
    }
}


