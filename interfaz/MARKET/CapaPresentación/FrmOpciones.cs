using System;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class FrmOpciones : Form
    {
        public FrmOpciones()
        {
            InitializeComponent();
        }

        private void BtnArea_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmArea();
            formulario.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmProducto();
            formulario.Show();
            this.Hide();
        }

        private void BtnFamila_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmFamilia();
            formulario.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmTamaño();
            formulario.Show();
            this.Hide();
        }
    }
}
