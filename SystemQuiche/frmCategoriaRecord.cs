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
    public partial class frmCategoriaRecord : Form
    {
        public frmCategoriaRecord()
        {
            InitializeComponent();
        }

        private void frmCategoriaRecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cadastroDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.cadastroDataSet.Category);

        }

        private void frmCategoriaRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            frmCategoria frm = new frmCategoria();
            frm.Show();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string strRowNumber = (e.RowIndex + 1).ToString();
            SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);
            if (dataGridView1.RowHeadersWidth < Convert.ToInt32((size.Width + 20)))
            {
                dataGridView1.RowHeadersWidth = Convert.ToInt32((size.Width + 20));
            }
            Brush b = SystemBrushes.ControlText;
            e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.Hide();
            frmCategoria frm = new frmCategoria();
            frm.txtNomeCategoria.Text = (dataGridView1.CurrentRow.Cells[1].Value.ToString());
            frm.btnDeletar.Enabled = true;
            frm.btnAtualizar.Enabled = true;
            frm.Show();
        }
    }
}
