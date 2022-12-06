using System;
using System.Windows.Forms;
using JorgeBeltranANDNemesisSierra.control;
using JorgeBeltranANDNemesisSierra.entidades;
using JorgeBeltranANDNemesisSierra.mensajes;
using JorgeBeltranANDNemesisSierra.recursos;

namespace JorgeBeltranANDNemesisSierra.vistas
{
    public partial class FrmClientes : Form
    { 
        ControlClientes controlclientes = new ControlClientes();
        int sel;
        public String idSel = "";
        Clientes cliente = new Clientes();
        public FrmClientes()
        {
            InitializeComponent();
            controlclientes.llenartablaClientes(DgvClientes);
            controlclientes.llenaCombo(CbxClientes);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbxID.Text = "";
            TbxNombre.Text = "";
            TbxApepat.Text = "";
            TbxApemat.Text = "";
            TbxDomicilio.Text = "";
            TbxColonia.Text = "";
            TbxTelefono.Text = "";
            TbxLimiteCredito.Text = "";
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            controlclientes.llenartablaClientes(DgvClientes);
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            if (TbxNombre.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.nombreProduc;
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
                Sesiones.mensajeError = Sesiones.mensajeError + "El domiclio no puede estar vacío.";
            }
            if (TbxColonia.Text == "")
            {                
                Sesiones.mensajeError = Sesiones.mensajeError + "La colonia no puede estar vacía.";
            }
            if (TbxTelefono.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El teléfono no puede estar vacío.";
            }
            if (TbxLimiteCredito.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El limite de crédito no puede estar vacía.";
            }
            if (Sesiones.mensajeError == "")
            {
                cliente.Nombre = TbxNombre.Text;
                cliente.Apepat = TbxApepat.Text;
                cliente.Apemat = TbxApemat.Text;
                cliente.Domicilio = TbxDomicilio.Text;
                cliente.Colonia = TbxColonia.Text;
                cliente.Telefono = TbxTelefono.Text;
                cliente.Limitecredito = Convert.ToInt32(TbxLimiteCredito.Text);
                controlclientes.registrarCliente(cliente, DgvClientes);            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (TbxNombre.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El nombre no puede estar vacía.";
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
                Sesiones.mensajeError = Sesiones.mensajeError + "El domiclio no puede estar vacío.";
            }
            if (TbxColonia.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La colonia no puede estar vacía.";
            }
            if (TbxTelefono.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El teléfono no puede estar vacío.";
            }
            if (TbxLimiteCredito.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El limite de crédito no puede estar vacía.";
            }
            if (Sesiones.mensajeError == "")
            {
                cliente.Nombre = TbxNombre.Text;
                cliente.Apepat = TbxApepat.Text;
                cliente.Apemat = TbxApemat.Text;
                cliente.Domicilio = TbxDomicilio.Text;
                cliente.Colonia = TbxColonia.Text;
                cliente.Telefono = TbxTelefono.Text;
                cliente.Limitecredito = Convert.ToInt32(TbxLimiteCredito.Text);
                cliente.Idcliente = Convert.ToInt32(idSel);
                controlclientes.consultarCliente(cliente, DgvClientes);
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
                Sesiones.mensajeError = Sesiones.mensajeError + "El nombre no puede estar vacía.";
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
                Sesiones.mensajeError = Sesiones.mensajeError + "El domiclio no puede estar vacío.";
            }
            if (TbxColonia.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La colonia no puede estar vacía.";
            }
            if (TbxTelefono.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El teléfono no puede estar vacío.";
            }
            if (TbxLimiteCredito.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El limite de crédito no puede estar vacía.";
            }
            if (Sesiones.mensajeError == "")
            {
                cliente.Nombre = TbxNombre.Text;
                cliente.Apepat = TbxApepat.Text;
                cliente.Apemat = TbxApemat.Text;
                cliente.Domicilio = TbxDomicilio.Text;
                cliente.Colonia = TbxColonia.Text;
                cliente.Telefono = TbxTelefono.Text;
                cliente.Limitecredito = Convert.ToInt32(TbxLimiteCredito.Text);
                cliente.Idcliente = Convert.ToInt32(idSel);
                controlclientes.eliminarCliente(cliente, DgvClientes);
            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }
        }

        private void DgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel = e.RowIndex;
            idSel = DgvClientes.Rows[sel].Cells[0].Value.ToString();
            TbxID.Text = DgvClientes.Rows[sel].Cells[0].Value.ToString();
            TbxNombre.Text = DgvClientes.Rows[sel].Cells[1].Value.ToString();
            TbxApepat.Text = DgvClientes.Rows[sel].Cells[2].Value.ToString();
            TbxApemat.Text = DgvClientes.Rows[sel].Cells[3].Value.ToString();
            TbxDomicilio.Text = DgvClientes.Rows[sel].Cells[4].Value.ToString();
            TbxColonia.Text = DgvClientes.Rows[sel].Cells[5].Value.ToString();
            TbxTelefono.Text = DgvClientes.Rows[sel].Cells[6].Value.ToString();
            TbxLimiteCredito.Text = DgvClientes.Rows[sel].Cells[7].Value.ToString();
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteClientes clientazo = new FrmReporteClientes();
            clientazo.ShowDialog();
        }

        private void CbxClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
