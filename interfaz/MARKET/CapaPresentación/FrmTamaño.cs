using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;

namespace CapaPresentación
{
    public partial class FrmTamaño : Form
    {

        private bool Editar = false;
        readonly E_Tamaño ObjEntidad = new E_Tamaño();
        readonly N_Tamaño ObjNegocio = new N_Tamaño();

        public FrmTamaño()
        {
            InitializeComponent();
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
            Data_listado.DataSource = N_Tamaño.MostrarRegistro();
        }

        public void LimpiarCajas()
        {
            Editar = false;
            TxtCodigo.Text = "";
            TxtMedida.Text = "";
            TxtMedida.Focus();
        }

        private void FrmTamaño_Load(object sender, EventArgs e)
        {
            MostrarRegistro();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (Data_listado.SelectedRows.Count > 0)
            {
                Editar = true;
                TxtCodigo.Text = Data_listado.CurrentRow.Cells[0].Value.ToString();
                TxtMedida.Text = Data_listado.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                MensajeError("Seleccione una fila primero");
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Data_listado.SelectedRows.Count > 0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea eliminar este registro?", "Valentina Market", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    ObjEntidad.Codigo = Convert.ToInt32(Data_listado.CurrentRow.Cells[0].Value.ToString());
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

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    ObjEntidad.Codigo = Convert.ToInt32(TxtCodigo.Text);
                    ObjEntidad.Medida = TxtMedida.Text.ToUpper();

                    ObjNegocio.InsertarRegistro(ObjEntidad);

                    MensajeConfirmacion("Se insertó correctamente");
                    MostrarRegistro();
                    LimpiarCajas();
                }
                catch (Exception)
                {
                    MensajeError("No se pudo insertar el registro");
                }
            }
            if (Editar == true)
            {
                try
                {
                    ObjEntidad.Codigo = Convert.ToInt32(TxtCodigo.Text);
                    ObjEntidad.Medida = TxtMedida.Text.ToUpper();

                    ObjNegocio.EditarRegistro(ObjEntidad);

                    MensajeConfirmacion("Se modificó correctamente");
                    MostrarRegistro();
                    LimpiarCajas();
                }
                catch (Exception)
                {
                    MensajeError("No se pudo modificar el registro");
                }
            }
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmOpciones();
            formulario.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
