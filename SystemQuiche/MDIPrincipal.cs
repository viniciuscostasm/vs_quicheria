using BLL;
using System;
using System.Windows.Forms;

namespace SystemQuiche{
    public partial class MDIPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
           
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Categorias = new frmCategoria();
            Categorias.MdiParent = this;
            Categorias.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Produtos = new frmProdutos();
            Produtos.MdiParent = this;
            Produtos.Show();
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form CadastroUsuario = new frmCadastroUsuario();
            CadastroUsuario.MdiParent = this;
            CadastroUsuario.Show();
        }

        private void loginDetalhesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Login_Detalhes = new frmLoginDetalhes();
            Login_Detalhes.MdiParent = this;
            Login_Detalhes.Show();
        }

        private void perfilToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Perfil_Clientes = new frmClientes();
            Perfil_Clientes.MdiParent = this;
            Perfil_Clientes.Show();
        }

        private void faturamentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Faturamento = new frmVendas();
            Faturamento.MdiParent = this;
            Faturamento.Show();
        }

        private void clientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form Relatorio_Clientes = new frmClientesReport();
            Relatorio_Clientes.MdiParent = this;
            Relatorio_Clientes.Show();
        }

        private void vendasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Relatorio_Vendas = new frmVendasReport();
            Relatorio_Vendas.MdiParent = this;
            Relatorio_Vendas.Show();
        }

        private void calculadoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void gereciadorDeTarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TaskMgr.exe");
        }

        private void mSWordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WinWord.exe");
        }

        private void notepadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Notepad.exe");
        }

        private void wordpadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WordPad.exe");
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSobre sobreSistema = new frmSobre();
            sobreSistema.MdiParent = this;
            sobreSistema.Show();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            RegistrationBLL reg = new RegistrationBLL();
            frmLogin frm = new frmLogin();
            var nome = frm.txtNomeUsuario.Text;
            var user = reg.Localizar(nome);
            toolStripStatusLabel1.Text = nome;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
        }

        private void faturamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Faturamento = new frmVendas();
            Faturamento.MdiParent = this;
            Faturamento.Show();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CadastroUsuario = new frmCadastroUsuario();
            CadastroUsuario.MdiParent = this;
            CadastroUsuario.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Produtos = new frmProdutos();
            Produtos.MdiParent = this;
            Produtos.Show();
        }

    }
}
