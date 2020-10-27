using System;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocios;

namespace CapaPresentación
{
    public partial class FrmMProducto : Form
    {

        readonly E_Producto ObjEntidad = new E_Producto();
        readonly N_Producto ObjNegocio = new N_Producto();

        public FrmMProducto()
        {
            InitializeComponent();
            LlenarComboBox();
        }

        private void MensajeConfirmacion(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Valentina Market", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Valentina Market", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Pb_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Txt_Codigo.Text.Trim() != "")
            {
                if (Program.Evento == 0)
                {
                    try
                    {
                        ObjEntidad.Codigo = Txt_Codigo.Text.ToUpper();
                        ObjEntidad.Area = Convert.ToInt32(CbArea.SelectedValue);
                        ObjEntidad.Familia = Convert.ToInt32(CbFamilia.SelectedValue);
                        ObjEntidad.Marca = Txt_Marca.Text.ToUpper();
                        ObjEntidad.Descripcion = Txt_Descripcion.Text.ToUpper();
                        ObjEntidad.Presentacion = Txt_Presentacion.Text.ToUpper();
                        ObjEntidad.Tamaño = Convert.ToInt32(CbTamaño.SelectedValue);
                        ObjEntidad.Cantidad = Convert.ToInt32(Txt_Cantidad.Text);
                        ObjEntidad.P_Compra = Convert.ToDecimal(Txt_P_Compra.Text);
                        ObjEntidad.P_Venta = Convert.ToDecimal(Txt_P_Venta.Text);

                        ObjNegocio.InsertarRegistro(ObjEntidad);
                        MensajeConfirmacion("Se insertó correctamente");
                        Program.Evento = 0;
                        Close();
                    }
                    catch (Exception)
                    {
                        MensajeError("No se pudo insertar el registro");
                    }
                }
                else
                {
                    try
                    {
                        ObjEntidad.Codigo = Txt_Codigo.Text.ToUpper();
                        ObjEntidad.Area = Convert.ToInt32(CbArea.SelectedValue);
                        ObjEntidad.Familia = Convert.ToInt32(CbFamilia.SelectedValue);
                        ObjEntidad.Marca = Txt_Marca.Text.ToUpper();
                        ObjEntidad.Descripcion = Txt_Descripcion.Text.ToUpper();
                        ObjEntidad.Presentacion = Txt_Presentacion.Text.ToUpper();
                        ObjEntidad.Tamaño = Convert.ToInt32(CbTamaño.SelectedValue);
                        ObjEntidad.Cantidad = Convert.ToInt32(Txt_Cantidad.Text);
                        ObjEntidad.P_Compra = Convert.ToDecimal(Txt_P_Compra.Text);
                        ObjEntidad.P_Venta = Convert.ToDecimal(Txt_P_Venta.Text);

                        ObjNegocio.InsertarRegistro(ObjEntidad);
                        MensajeConfirmacion("Se modificó correctamente");
                        Program.Evento = 0;
                    }
                    catch (Exception)
                    {
                        MensajeError("No se pudo modificar el registro");
                    }
                }
            }
            else
            {
                MensajeError("Llene los campos correspondientes para guardar el registro.");
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LlenarComboBox()
        {
            CbArea.DataSource = N_Area.MostrarRegistro();
            CbArea.ValueMember = "TIPO";
            CbArea.DisplayMember = "NOMBRE";

            CbFamilia.DataSource = N_Familia.MostrarRegistro();
            CbFamilia.ValueMember = "TIPO";
            CbFamilia.DisplayMember = "NOMBRE";

            CbTamaño.DataSource = N_Tamaño.MostrarRegistro();
            CbTamaño.ValueMember = "CODIGO";
            CbTamaño.DisplayMember = "MEDIDA";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
