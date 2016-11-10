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
    public partial class frmCadastroUsuario : Form
    {
        RegistrationBLL reg;
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        private void btnNovoCadastro_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            reg = new RegistrationBLL();
            reg.AdicionarRegistration(txtNomeUsuario.Text, cmbTipoUsuario.Text, txtSenha.Text, txtNome.Text, txtNumContato.Text, txtEmail.Text);
            MessageBox.Show("Usuário cadastrado com sucesso", "My Application",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            txtNomeUsuario.Clear();
            txtSenha.Clear();
            txtNumContato.Clear();
            txtNome.Clear();
            txtEmail.Clear();
        }
    }
}
