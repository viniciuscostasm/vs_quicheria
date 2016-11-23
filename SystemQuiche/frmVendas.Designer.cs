using DAL;

namespace SystemQuiche
{
    partial class frmVendas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.btnProcurarPedido = new System.Windows.Forms.Button();
            this.dtpDataPedido = new System.Windows.Forms.DateTimePicker();
            this.txtProdutoID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIncluirCarrinho = new System.Windows.Forms.Button();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.txtQtdVenda = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbNomeProduto = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroDataSet = new DAL.CadastroDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtualiar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalPago = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtValorDevido = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescontoAmount = new System.Windows.Forms.TextBox();
            this.txtDescontoPer = new System.Windows.Forms.TextBox();
            this.txtTaxAmt = new System.Windows.Forms.TextBox();
            this.txtTaxPer = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.productTableAdapter = new DAL.CadastroDataSetTableAdapters.ProductTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 96;
            this.label1.Text = "Faturamento:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(34, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 99;
            this.label2.Text = "Nº Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(34, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 100;
            this.label3.Text = "Data Pedido";
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.Location = new System.Drawing.Point(159, 61);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.ReadOnly = true;
            this.txtNumPedido.Size = new System.Drawing.Size(185, 24);
            this.txtNumPedido.TabIndex = 0;
            // 
            // btnProcurarPedido
            // 
            this.btnProcurarPedido.ForeColor = System.Drawing.Color.DarkRed;
            this.btnProcurarPedido.Location = new System.Drawing.Point(360, 61);
            this.btnProcurarPedido.Name = "btnProcurarPedido";
            this.btnProcurarPedido.Size = new System.Drawing.Size(75, 24);
            this.btnProcurarPedido.TabIndex = 106;
            this.btnProcurarPedido.Text = "Procurar";
            this.btnProcurarPedido.UseVisualStyleBackColor = true;
            this.btnProcurarPedido.Click += new System.EventHandler(this.btnProcurarPedido_Click);
            // 
            // dtpDataPedido
            // 
            this.dtpDataPedido.CustomFormat = "dd/MM/yyyy";
            this.dtpDataPedido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataPedido.Location = new System.Drawing.Point(159, 96);
            this.dtpDataPedido.Name = "dtpDataPedido";
            this.dtpDataPedido.Size = new System.Drawing.Size(120, 24);
            this.dtpDataPedido.TabIndex = 1;
            // 
            // txtProdutoID
            // 
            this.txtProdutoID.Location = new System.Drawing.Point(439, 12);
            this.txtProdutoID.Name = "txtProdutoID";
            this.txtProdutoID.Size = new System.Drawing.Size(100, 24);
            this.txtProdutoID.TabIndex = 114;
            this.txtProdutoID.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIncluirCarrinho);
            this.groupBox1.Controls.Add(this.txtValorTotal);
            this.groupBox1.Controls.Add(this.txtQtdVenda);
            this.groupBox1.Controls.Add(this.txtPreco);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbNomeProduto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(37, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(651, 147);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalhes do Produto";
            // 
            // btnIncluirCarrinho
            // 
            this.btnIncluirCarrinho.Location = new System.Drawing.Point(558, 27);
            this.btnIncluirCarrinho.Name = "btnIncluirCarrinho";
            this.btnIncluirCarrinho.Size = new System.Drawing.Size(87, 54);
            this.btnIncluirCarrinho.TabIndex = 6;
            this.btnIncluirCarrinho.Text = "&Incluir no Carrinho";
            this.btnIncluirCarrinho.UseVisualStyleBackColor = true;
            this.btnIncluirCarrinho.Click += new System.EventHandler(this.btnIncluirCarrinho_Click);
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Location = new System.Drawing.Point(138, 103);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.ReadOnly = true;
            this.txtValorTotal.Size = new System.Drawing.Size(132, 24);
            this.txtValorTotal.TabIndex = 93;
            // 
            // txtQtdVenda
            // 
            this.txtQtdVenda.Location = new System.Drawing.Point(370, 64);
            this.txtQtdVenda.Name = "txtQtdVenda";
            this.txtQtdVenda.Size = new System.Drawing.Size(89, 24);
            this.txtQtdVenda.TabIndex = 1;
            this.txtQtdVenda.TextChanged += new System.EventHandler(this.txtQtdVenda_TextChanged);
            this.txtQtdVenda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdVenda_KeyPress);
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(138, 64);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(89, 24);
            this.txtPreco.TabIndex = 3;
            this.txtPreco.TextChanged += new System.EventHandler(this.txtPreco_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 17);
            this.label7.TabIndex = 89;
            this.label7.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 76;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 87;
            this.label5.Text = "Preço Unitário";
            // 
            // cmbNomeProduto
            // 
            this.cmbNomeProduto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbNomeProduto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbNomeProduto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "ProductID", true));
            this.cmbNomeProduto.DataSource = this.productBindingSource;
            this.cmbNomeProduto.DisplayMember = "ProductName";
            this.cmbNomeProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNomeProduto.FormattingEnabled = true;
            this.cmbNomeProduto.Location = new System.Drawing.Point(138, 25);
            this.cmbNomeProduto.Name = "cmbNomeProduto";
            this.cmbNomeProduto.Size = new System.Drawing.Size(401, 25);
            this.cmbNomeProduto.TabIndex = 0;
            this.cmbNomeProduto.ValueMember = "ProductID";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.cadastroDataSet;
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "CadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 74;
            this.label4.Text = "Nome do Produto";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(37, 288);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(651, 376);
            this.listView1.TabIndex = 108;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Produto ID";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome Produto";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 270;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Preço";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Qtde.";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Valor Total";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 120;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnAtualiar);
            this.panel1.Controls.Add(this.btnDeletar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnNovo);
            this.panel1.ForeColor = System.Drawing.Color.DarkRed;
            this.panel1.Location = new System.Drawing.Point(704, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(112, 152);
            this.panel1.TabIndex = 112;
            // 
            // btnAtualiar
            // 
            this.btnAtualiar.Enabled = false;
            this.btnAtualiar.Location = new System.Drawing.Point(14, 113);
            this.btnAtualiar.Name = "btnAtualiar";
            this.btnAtualiar.Size = new System.Drawing.Size(84, 29);
            this.btnAtualiar.TabIndex = 100;
            this.btnAtualiar.Text = "&Atualizar";
            this.btnAtualiar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Enabled = false;
            this.btnDeletar.Location = new System.Drawing.Point(14, 78);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(84, 29);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "&Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(14, 43);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(84, 29);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "&Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(14, 8);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(84, 29);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.DarkRed;
            this.label8.Location = new System.Drawing.Point(694, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 119;
            this.label8.Text = "Observações";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacoes.Location = new System.Drawing.Point(695, 312);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtObservacoes.Size = new System.Drawing.Size(229, 91);
            this.txtObservacoes.TabIndex = 118;
            this.txtObservacoes.Text = "";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTotalPago);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.txtValorDevido);
            this.panel2.Controls.Add(this.txtTotal);
            this.panel2.Controls.Add(this.txtDescontoAmount);
            this.panel2.Controls.Add(this.txtDescontoPer);
            this.panel2.Controls.Add(this.txtTaxAmt);
            this.panel2.Controls.Add(this.txtTaxPer);
            this.panel2.Controls.Add(this.txtSubTotal);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Location = new System.Drawing.Point(695, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 221);
            this.panel2.TabIndex = 109;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtTotalPago
            // 
            this.txtTotalPago.Enabled = false;
            this.txtTotalPago.Location = new System.Drawing.Point(116, 151);
            this.txtTotalPago.Name = "txtTotalPago";
            this.txtTotalPago.Size = new System.Drawing.Size(81, 24);
            this.txtTotalPago.TabIndex = 102;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.DarkRed;
            this.label16.Location = new System.Drawing.Point(174, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 21);
            this.label16.TabIndex = 101;
            this.label16.Text = "%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.DarkRed;
            this.label15.Location = new System.Drawing.Point(174, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 21);
            this.label15.TabIndex = 92;
            this.label15.Text = "%";
            // 
            // txtValorDevido
            // 
            this.txtValorDevido.BackColor = System.Drawing.Color.White;
            this.txtValorDevido.Enabled = false;
            this.txtValorDevido.Location = new System.Drawing.Point(116, 183);
            this.txtValorDevido.Name = "txtValorDevido";
            this.txtValorDevido.ReadOnly = true;
            this.txtValorDevido.Size = new System.Drawing.Size(81, 24);
            this.txtValorDevido.TabIndex = 8;
            this.txtValorDevido.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(116, 117);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(81, 24);
            this.txtTotal.TabIndex = 9;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescontoAmount
            // 
            this.txtDescontoAmount.BackColor = System.Drawing.Color.White;
            this.txtDescontoAmount.Enabled = false;
            this.txtDescontoAmount.Location = new System.Drawing.Point(220, 82);
            this.txtDescontoAmount.Name = "txtDescontoAmount";
            this.txtDescontoAmount.ReadOnly = true;
            this.txtDescontoAmount.Size = new System.Drawing.Size(80, 24);
            this.txtDescontoAmount.TabIndex = 7;
            this.txtDescontoAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescontoPer
            // 
            this.txtDescontoPer.BackColor = System.Drawing.Color.White;
            this.txtDescontoPer.Enabled = false;
            this.txtDescontoPer.Location = new System.Drawing.Point(116, 83);
            this.txtDescontoPer.Name = "txtDescontoPer";
            this.txtDescontoPer.Size = new System.Drawing.Size(52, 24);
            this.txtDescontoPer.TabIndex = 1;
            this.txtDescontoPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescontoPer.TextChanged += new System.EventHandler(this.txtDescontoPer_TextChanged);
            // 
            // txtTaxAmt
            // 
            this.txtTaxAmt.BackColor = System.Drawing.Color.White;
            this.txtTaxAmt.Enabled = false;
            this.txtTaxAmt.Location = new System.Drawing.Point(220, 47);
            this.txtTaxAmt.Name = "txtTaxAmt";
            this.txtTaxAmt.ReadOnly = true;
            this.txtTaxAmt.Size = new System.Drawing.Size(80, 24);
            this.txtTaxAmt.TabIndex = 0;
            this.txtTaxAmt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTaxPer
            // 
            this.txtTaxPer.BackColor = System.Drawing.Color.White;
            this.txtTaxPer.Enabled = false;
            this.txtTaxPer.Location = new System.Drawing.Point(116, 48);
            this.txtTaxPer.Name = "txtTaxPer";
            this.txtTaxPer.Size = new System.Drawing.Size(52, 24);
            this.txtTaxPer.TabIndex = 100;
            this.txtTaxPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTaxPer.TextChanged += new System.EventHandler(this.txtTaxPer_TextChanged);
            this.txtTaxPer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTaxPer_KeyPress);
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.BackColor = System.Drawing.Color.White;
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(116, 14);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.Size = new System.Drawing.Size(184, 24);
            this.txtSubTotal.TabIndex = 5;
            this.txtSubTotal.TextChanged += new System.EventHandler(this.txtSubTotal_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.DarkRed;
            this.label14.Location = new System.Drawing.Point(19, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 17);
            this.label14.TabIndex = 96;
            this.label14.Text = "Valor Devido";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.DarkRed;
            this.label13.Location = new System.Drawing.Point(19, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 17);
            this.label13.TabIndex = 95;
            this.label13.Text = "Total Pago";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.DarkRed;
            this.label12.Location = new System.Drawing.Point(19, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 17);
            this.label12.TabIndex = 94;
            this.label12.Text = "Total Geral";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.DarkRed;
            this.label11.Location = new System.Drawing.Point(19, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 99;
            this.label11.Text = "Desconto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.DarkRed;
            this.label10.Location = new System.Drawing.Point(20, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 90;
            this.label10.Text = "Imposto";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.DarkRed;
            this.label9.Location = new System.Drawing.Point(19, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 77;
            this.label9.Text = "Sub Total";
            // 
            // btnRemover
            // 
            this.btnRemover.Enabled = false;
            this.btnRemover.ForeColor = System.Drawing.Color.DarkRed;
            this.btnRemover.Location = new System.Drawing.Point(694, 635);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(86, 29);
            this.btnRemover.TabIndex = 110;
            this.btnRemover.Text = "&Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPrint.Location = new System.Drawing.Point(786, 635);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(128, 29);
            this.btnPrint.TabIndex = 111;
            this.btnPrint.Text = "&Imprimir Fatura";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // frmVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 676);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtObservacoes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtProdutoID);
            this.Controls.Add(this.dtpDataPedido);
            this.Controls.Add(this.btnProcurarPedido);
            this.Controls.Add(this.txtNumPedido);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmVendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.Load += new System.EventHandler(this.frmVendas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtNumPedido;
        internal System.Windows.Forms.Button btnProcurarPedido;
        internal System.Windows.Forms.DateTimePicker dtpDataPedido;
        public System.Windows.Forms.TextBox txtProdutoID;
        internal System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNomeProduto;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Button btnIncluirCarrinho;
        internal System.Windows.Forms.TextBox txtValorTotal;
        internal System.Windows.Forms.TextBox txtQtdVenda;
        internal System.Windows.Forms.TextBox txtPreco;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        public System.Windows.Forms.ListView listView1;
        internal System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        internal System.Windows.Forms.ColumnHeader columnHeader2;
        internal System.Windows.Forms.ColumnHeader columnHeader3;
        internal System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        internal System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btnAtualiar;
        internal System.Windows.Forms.Button btnDeletar;
        internal System.Windows.Forms.Button btnSalvar;
        internal System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.RichTextBox txtObservacoes;
        internal System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.Label label10;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.Label label16;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.TextBox txtValorDevido;
        internal System.Windows.Forms.TextBox txtTotal;
        internal System.Windows.Forms.TextBox txtDescontoAmount;
        internal System.Windows.Forms.TextBox txtDescontoPer;
        internal System.Windows.Forms.TextBox txtTaxAmt;
        internal System.Windows.Forms.TextBox txtTaxPer;
        internal System.Windows.Forms.TextBox txtSubTotal;
        internal System.Windows.Forms.Button btnRemover;
        internal System.Windows.Forms.Button btnPrint;
        private DAL.CadastroDataSet cadastroDataSet;
        private DAL.CadastroDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox txtTotalPago;
    }
}