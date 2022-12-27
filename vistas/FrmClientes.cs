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
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.apePat;
            }
            if (TbxApemat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.apeMat;
            }
            if (TbxDomicilio.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.domicilio;
            }
            if (TbxColonia.Text == "")
            {                
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.colonia;
            }
            if (TbxTelefono.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.telefono;
            }
            if (TbxLimiteCredito.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.LimiteCredito;
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
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.nombreProduc;
            }
            if (TbxApepat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.apePat;
            }
            if (TbxApemat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.apeMat;
            }
            if (TbxDomicilio.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.domicilio;
            }
            if (TbxColonia.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.colonia;
            }
            if (TbxTelefono.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.telefono;
            }
            if (TbxLimiteCredito.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.LimiteCredito;
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
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.nombreProduc;
            }
            if (TbxApepat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.apePat;
            }
            if (TbxApemat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.apeMat;
            }
            if (TbxDomicilio.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.domicilio;
            }
            if (TbxColonia.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.colonia;
            }
            if (TbxTelefono.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.telefono;
            }
            if (TbxLimiteCredito.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.LimiteCredito;
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

        private void TbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void TbxApepat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void TbxApemat_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloLetras(e);
        }

        private void DgvClientes_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
                int posicion = DgvClientes.HitTest(e.X, e.Y).RowIndex;
                if (posicion > -1)
                {
                    menu.Items.Add("Borrar").Name = "Borrar" + posicion;
                    menu.Items.Add("Mostrar").Name = "Mostrar" + posicion;
                }
                menu.Show(DgvClientes, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menuclick);
            }
        }

        //----------------------------------------------------------------------------------
        //Menú desplegable
        //Pendiente.
        //----------------------------------------------------------------------------------
        private void menuclick(object sender, ToolStripItemClickedEventArgs e)
        {
            string id2 = e.ClickedItem.Name.ToString();
            string idSel = "";
            if (id2.Contains("Borrar"))
            {
                id2 = id2.Replace("Borrar", "");
                idSel = DgvClientes.Rows[int.Parse(id2)].Cells[0].Value.ToString();
                Borrar(int.Parse(idSel));
            }
            if (id2.Contains("Mostrar"))
            {
                id2 = id2.Replace("Mostrar", "");
                Mostrar(int.Parse(id2));
            }
        }

        private void Mostrar(int idMostrar)
        {
            String res = "ID del cliente = " + DgvClientes.Rows[idMostrar].Cells[0].Value.ToString() + "\n";
            res = res + "Nombre del cliente = " + DgvClientes.Rows[idMostrar].Cells[1].Value.ToString() + "\n";
            res = res + "Apellido Paterno del cliente = " + DgvClientes.Rows[idMostrar].Cells[2].Value.ToString() + "\n";
            res = res + "Apellido Materno del cliente = " + DgvClientes.Rows[idMostrar].Cells[3].Value.ToString() + "\n";
            res = res + "Domicilio del cliente = " + DgvClientes.Rows[idMostrar].Cells[4].Value.ToString() + "\n";
            res = res + "Colonia del cliente = " + DgvClientes.Rows[idMostrar].Cells[5].Value.ToString() + "\n";
            res = res + "Télefono del cliente = " + DgvClientes.Rows[idMostrar].Cells[6].Value.ToString() + "\n";
            res = res + "Límite de crédito del cliente = " + DgvClientes.Rows[idMostrar].Cells[7].Value.ToString() + "\n";
            MessageBox.Show(res);
        }

        private void Borrar(int idBorrar)
        {
            controlclientes.EliminarSelc(idBorrar, DgvClientes);
        }

    }
}
