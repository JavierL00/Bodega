using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;

namespace CapaPresentación
{
    public partial class FrmProducto : Form
    {

        readonly E_Producto ObjEntidad = new E_Producto();
        readonly N_Producto ObjNegocio = new N_Producto();

        public FrmProducto()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MensajeConfirmacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Valentina Market", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Valentina Market", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MostrarRegistro()
        {
            DGV1.DataSource = N_Producto.MostrarRegistro();
        }

        public void BuscarRegistro()
        {
            DGV1.DataSource = N_Producto.BuscarProducto(TxtBuscar.Text);
        }

        private void ActualizarDatos(object sender, FormClosedEventArgs e)
        {
            MostrarRegistro();
        }

        private void FrmEleccionProducto_Load(object sender, EventArgs e)
        {
            MostrarRegistro();
        }

        private void BtnNuevoProducto_Click(object sender, EventArgs e)
        {
            FrmMProducto formulariom = new FrmMProducto();
            formulariom.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            formulariom.ShowDialog();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmInicio();
            formulario.Show();
            this.Hide();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DGV1.SelectedRows.Count > 0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea eliminar este registro?", "Valentina Market", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    ObjEntidad.Codigo = DGV1.CurrentRow.Cells[0].Value.ToString();
                    ObjNegocio.EliminarRegistro(ObjEntidad);

                    MensajeConfirmacion("Se eliminó correctamente el registro.");

                    MostrarRegistro();
                }
            }
            else
            {
                MensajeError("Seleccione primero una fila a eliminar");
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            FrmMProducto formulario2 = new FrmMProducto();
            formulario2.FormClosed += new FormClosedEventHandler(ActualizarDatos);
            if (DGV1.SelectedRows.Count > 0)
            {
                Program.Evento = 1;
                formulario2.Txt_Codigo.Text = DGV1.CurrentRow.Cells[0].Value.ToString();
                formulario2.CbArea.Text = DGV1.CurrentRow.Cells[1].Value.ToString();
                formulario2.CbFamilia.Text = DGV1.CurrentRow.Cells[2].Value.ToString();
                formulario2.Txt_Marca.Text = DGV1.CurrentRow.Cells[3].Value.ToString();
                formulario2.Txt_Descripcion.Text = DGV1.CurrentRow.Cells[4].Value.ToString();
                formulario2.Txt_Presentacion.Text = DGV1.CurrentRow.Cells[5].Value.ToString();
                formulario2.CbTamaño.Text = DGV1.CurrentRow.Cells[6].Value.ToString();
                formulario2.Txt_Cantidad.Text = DGV1.CurrentRow.Cells[7].Value.ToString();
                formulario2.Txt_P_Compra.Text = DGV1.CurrentRow.Cells[8].Value.ToString();
                formulario2.Txt_P_Venta.Text = DGV1.CurrentRow.Cells[9].Value.ToString();
                formulario2.ShowDialog();
            }
            else
            {
                MensajeError("Selecciona la fila a editar.");
            }
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarRegistro();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmOpciones();
            formulario.Show();
            this.Hide();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmInicio();
            formulario.Show();
            this.Hide();
        }
    }
}
