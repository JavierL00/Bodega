using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;

namespace CapaPresentación
{
    public partial class FrmFamilia : Form
    {

        private bool Editar = false;
        readonly E_Familia ObjEntidad = new E_Familia();
        readonly N_Familia ObjNegocio = new N_Familia();

        public FrmFamilia()
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
            Data_listado.DataSource = N_Familia.MostrarRegistro();
        }

        public void LimpiarCajas()
        {
            Editar = false;
            Txt_Tipo.Text = "";
            Txt_Nombre.Text = "";
            Txt_Nombre.Focus();
        }

        private void FrmFamilia_Load(object sender, EventArgs e)
        {
            MostrarRegistro();
        }

        private void Pb_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            LimpiarCajas();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (Data_listado.SelectedRows.Count > 0)
            {
                DialogResult opcion;
                opcion = MessageBox.Show("¿Desea eliminar este registro?", "Valentina Market", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    ObjEntidad.Tipo = Convert.ToInt32(Data_listado.CurrentRow.Cells[0].Value.ToString());
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
            if (Data_listado.SelectedRows.Count > 0)
            {
                Editar = true;
                Txt_Tipo.Text = Data_listado.CurrentRow.Cells[0].Value.ToString();
                Txt_Nombre.Text = Data_listado.CurrentRow.Cells[1].Value.ToString();
            }
            else
            {
                MensajeError("Seleccione una fila primero");
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    ObjEntidad.Tipo = Convert.ToInt32(Txt_Tipo.Text);
                    ObjEntidad.Nombre = Txt_Nombre.Text.ToUpper();

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
                    ObjEntidad.Tipo = Convert.ToInt32(Txt_Tipo.Text);
                    ObjEntidad.Nombre = Txt_Nombre.Text.ToUpper();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnAtras_Click(object sender, EventArgs e)
        {
            Form formulario = new FrmOpciones();
            formulario.Show();
            this.Hide();
        }
    }
}
