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

namespace SystemQuiche
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        private void auto()
        {
            txtNumPedido.Text = "OD-" + GetUniquekey(8);
        }

        public static string GetUniquekey(int maxSize)
        {
            char[] chars = new char[62];
            chars = "123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }


        public void Calcular()
        {
            if (txtTaxPer.Text != "")
            {
                txtTaxAmt.Text = Convert.ToInt32((Convert.ToInt32(txtSubTotal.Text) * Convert.ToDouble(txtTaxPer.Text) / 100)).ToString();
            }
            if (txtDescontoPer.Text != "")
            {
                txtDescontoAmount.Text = Convert.ToInt32(((Convert.ToInt32(txtSubTotal.Text) + Convert.ToInt32(txtTaxAmt.Text)) * Convert.ToDouble(txtDescontoPer.Text) / 100)).ToString();
            }
            int val1 = 0;
            int val2 = 0;
            int val3 = 0;
            int val4 = 0;
            int val5 = 0;
            int.TryParse(txtTaxAmt.Text, out val1);
            int.TryParse(txtSubTotal.Text, out val2);
            int.TryParse(txtDescontoAmount.Text, out val3);
            int.TryParse(txtTotal.Text, out val4);
            int.TryParse(txtTotalPago.Text, out val5);
            val4 = val1 + val2 - val3;
            txtTotal.Text = val4.ToString();
            int I = (val4 - val5);
            txtValorDevido.Text = I.ToString();
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmVendas_Load(object sender, EventArgs e)
        {

        }

        private void txtQtdVenda_TextChanged(object sender, EventArgs e)
        {
            int val1 = 0;
            int val2 = 0;
            int.TryParse(txtPreco.Text, out val1);
            int.TryParse(txtQtdVenda.Text, out val2);
            int I = (val1 * val2);
            txtValorTotal.Text = I.ToString();
        }

        public double subtotal()
        {
            int i = 0;
            int j = 0;
            int k = 0;
            i = 0;
            j = 0;
            k = 0;

            try
            {
                j = listView1.Items.Count;
                for (i = 0; i <= j - 1; i++)
                {
                    k = k + Convert.ToInt32(listView1.Items[i].SubItems[5].Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return k;
        }

        private void btnIncluirCarrinho_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbNomeProduto.Text == "")
                {
                    MessageBox.Show("Selecione o nome do produto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (txtQtdVenda.Text == "")
                {
                    MessageBox.Show("Informe a quantidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQtdVenda.Focus();
                    return;
                }
                int QtdVenda = Convert.ToInt32(txtQtdVenda.Text);
                if (QtdVenda == 0)
                {
                    MessageBox.Show("Quantidade não pode ser zero", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtQtdVenda.Focus();
                    return;
                }

                if (listView1.Items.Count == 0)
                {
                    ListViewItem lst = new ListViewItem();
                    lst.SubItems.Add(txtProdutoID.Text);
                    lst.SubItems.Add(cmbNomeProduto.Text);
                    lst.SubItems.Add(txtPreco.Text);
                    lst.SubItems.Add(txtQtdVenda.Text);
                    lst.SubItems.Add(txtValorTotal.Text);
                    listView1.Items.Add(lst);
                    txtSubTotal.Text = subtotal().ToString();

                    Calcular();
                    cmbNomeProduto.Text = "";
                    txtProdutoID.Text = "";
                    txtPreco.Text = "";
                    txtQtdVenda.Text = "";
                    txtValorTotal.Text = "";
                    return;
                }

                for (int j = 0; j <= listView1.Items.Count - 1; j++)
                {
                    if (listView1.Items[j].SubItems[1].Text == txtProdutoID.Text)
                    {
                        listView1.Items[j].SubItems[1].Text = txtProdutoID.Text;
                        listView1.Items[j].SubItems[2].Text = cmbNomeProduto.Text;
                        listView1.Items[j].SubItems[3].Text = txtPreco.Text;
                        listView1.Items[j].SubItems[4].Text = (Convert.ToInt32(listView1.Items[j].SubItems[4].Text) + Convert.ToInt32(txtQtdVenda.Text)).ToString();
                        listView1.Items[j].SubItems[5].Text = (Convert.ToInt32(listView1.Items[j].SubItems[5].Text) + Convert.ToInt32(txtValorTotal.Text)).ToString();
                        txtSubTotal.Text = subtotal().ToString();
                        Calcular();
                        cmbNomeProduto.Text = "";
                        txtProdutoID.Text = "";
                        txtPreco.Text = "";
                        txtQtdVenda.Text = "";
                        txtValorTotal.Text = "";
                        return;

                    }
                }

                ListViewItem lst1 = new ListViewItem();

                lst1.SubItems.Add(txtProdutoID.Text);
                lst1.SubItems.Add(cmbNomeProduto.Text);
                lst1.SubItems.Add(txtPreco.Text);
                lst1.SubItems.Add(txtQtdVenda.Text);
                lst1.SubItems.Add(txtValorTotal.Text);
                listView1.Items.Add(lst1);
                txtSubTotal.Text = subtotal().ToString();
                Calcular();
                cmbNomeProduto.Text = "";
                txtProdutoID.Text = "";
                txtPreco.Text = "";
                txtQtdVenda.Text = "";
                txtValorTotal.Text = "";
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtTaxPer_TextChanged(object sender, EventArgs e)
        {
            try
            {
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            Reset();
        }

        private void txtTotalPago_TextChanged(object sender, EventArgs e)
        {
            int val1 = 0;
            int val2 = 0;
            int.TryParse(txtTotal.Text, out val1);
            int.TryParse(txtTotalPago.Text, out val2);
            int I = (val1 - val2);
            txtValorDevido.Text = I.ToString();
        }

        private void txtTotalPago_Validating(object sender, CancelEventArgs e)
        {
            int val1 = 0;
            int val2 = 0;
            int.TryParse(txtTotal.Text, out val1);
            int.TryParse(txtTotalPago.Text, out val2);
            if (val2 > val1)
            {
                MessageBox.Show("Valor Pago não pode ser maior que o valor total", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotalPago.Text = "";
                txtValorDevido.Text = "";
                txtTotalPago.Focus();
                return;
            }
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
            Calcular();
        }
    }
}

       
