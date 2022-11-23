using System;
using System.Windows.Forms;
using JorgeBeltranANDNemesisSierra.control;
using JorgeBeltranANDNemesisSierra.recursos;
using JorgeBeltranANDNemesisSierra.entidades;

namespace JorgeBeltranANDNemesisSierra.vistas
{
    public partial class FrmProveedores : Form
    {
        controlProveedores control = new controlProveedores();
        int sel;
        public String idSel = "";
        Proveedores proveedor = new Proveedores();
        public FrmProveedores()
        {
            InitializeComponent();
            control.actualizarTabla(DgvProveedores);
            DgvProveedores.Columns[8].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProveedores.AutoResizeColumns();
        }      

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbxID.Text = "";
            TbxNombre.Text = "";
            TbxApepat.Text = "";
            TbxApemat.Text = "";
            TbxDomicilio.Text = "";
            TbxEmpresa.Text = "";
            TbxColonia.Text = "";
            TbxTelefono.Text = "";
            TbxCorreo.Text = "";
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            control.actualizarTabla(DgvProveedores);
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {            
            if (TbxNombre.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El nombre no puede estar vacío.";
            }
            if (TbxApepat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El Apellido paterno no puede estar vacío.";
            }
            if (TbxApemat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El Apellido materno no puede estar vacío.";
            }
            if (TbxDomicilio.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El domicilio no puede estar vacío.";
            }
            if (TbxEmpresa.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El nombre de empresa no puede estar vacío.";
            }
            if (TbxColonia.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La colonia no puede estar vacía.";
            }
            if (TbxTelefono.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El teléfono no puede estar vacío.";
            }
            if (TbxCorreo.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El correo no puede estar vacío.";
            }

            if (Sesiones.mensajeError == "")
            {
                proveedor.Nombre = TbxNombre.Text;
                proveedor.Apepat = TbxApepat.Text;
                proveedor.Apemat = TbxApemat.Text;
                proveedor.Domicilio = TbxDomicilio.Text;
                proveedor.Empresa = TbxEmpresa.Text;
                proveedor.Colonia = TbxColonia.Text;
                proveedor.Telefono = TbxTelefono.Text;
                proveedor.Correo = TbxCorreo.Text;
                control.registrarProveedores(proveedor, DgvProveedores);
            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }
        }

        private void DgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel = e.RowIndex;
            idSel = DgvProveedores.Rows[sel].Cells[0].Value.ToString();
            TbxID.Text = DgvProveedores.Rows[sel].Cells[0].Value.ToString();
            TbxNombre.Text = DgvProveedores.Rows[sel].Cells[1].Value.ToString();
            TbxApepat.Text = DgvProveedores.Rows[sel].Cells[2].Value.ToString();
            TbxApemat.Text = DgvProveedores.Rows[sel].Cells[3].Value.ToString();
            TbxDomicilio.Text = DgvProveedores.Rows[sel].Cells[4].Value.ToString();
            TbxEmpresa.Text = DgvProveedores.Rows[sel].Cells[5].Value.ToString();
            TbxColonia.Text = DgvProveedores.Rows[sel].Cells[6].Value.ToString();
            TbxTelefono.Text = DgvProveedores.Rows[sel].Cells[7].Value.ToString();
            TbxCorreo.Text = DgvProveedores.Rows[sel].Cells[8].Value.ToString();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (TbxNombre.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El nombre no puede estar vacío.";
            }
            if (TbxApepat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El Apellido paterno no puede estar vacío.";
            }
            if (TbxApemat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El Apellido materno no puede estar vacío.";
            }
            if (TbxDomicilio.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El domicilio no puede estar vacío.";
            }
            if (TbxEmpresa.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El nombre de empresa no puede estar vacío.";
            }
            if (TbxColonia.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La colonia no puede estar vacía.";
            }
            if (TbxTelefono.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El teléfono no puede estar vacío.";
            }
            if (TbxCorreo.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El correo no puede estar vacío.";
            }

            if (Sesiones.mensajeError == "")
            {
                proveedor.Nombre = TbxNombre.Text;
                proveedor.Apepat = TbxApepat.Text;
                proveedor.Apemat = TbxApemat.Text;
                proveedor.Domicilio = TbxDomicilio.Text;
                proveedor.Empresa = TbxEmpresa.Text;
                proveedor.Colonia = TbxColonia.Text;
                proveedor.Telefono = TbxTelefono.Text;
                proveedor.Correo = TbxCorreo.Text;
                proveedor.IdProveedor = Convert.ToInt32(TbxID.Text);
                control.modificarProveedores(proveedor, DgvProveedores);
            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TbxNombre.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El nombre no puede estar vacío.";
            }
            if (TbxApepat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El Apellido paterno no puede estar vacío.";
            }
            if (TbxApemat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El Apellido materno no puede estar vacío.";
            }
            if (TbxDomicilio.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El domicilio no puede estar vacío.";
            }
            if (TbxEmpresa.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El nombre de empresa no puede estar vacío.";
            }
            if (TbxColonia.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La colonia no puede estar vacía.";
            }
            if (TbxTelefono.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El teléfono no puede estar vacío.";
            }
            if (TbxCorreo.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El correo no puede estar vacío.";
            }

            if (Sesiones.mensajeError == "")
            {
                proveedor.Nombre = TbxNombre.Text;
                proveedor.Apepat = TbxApepat.Text;
                proveedor.Apemat = TbxApemat.Text;
                proveedor.Domicilio = TbxDomicilio.Text;
                proveedor.Empresa = TbxEmpresa.Text;
                proveedor.Colonia = TbxColonia.Text;
                proveedor.Telefono = TbxTelefono.Text;
                proveedor.Correo = TbxCorreo.Text;
                proveedor.IdProveedor = Convert.ToInt32(TbxID.Text);
                control.eliminarProveedores(proveedor, DgvProveedores);
            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }
        }

    }
}
