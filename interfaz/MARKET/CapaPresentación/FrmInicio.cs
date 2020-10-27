using System;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmProducto();
            formulario.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
