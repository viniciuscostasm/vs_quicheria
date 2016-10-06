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

namespace SystemQuiche
{
    public partial class frmLogin : Form
    {
        

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            progressBar1.Visible = false;
            txtNomeUsuario.Focus();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }
    }
}


