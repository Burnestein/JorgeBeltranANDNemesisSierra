using System;
using System.Windows.Forms;
using JorgeBeltranANDNemesisSierra.control;
using JorgeBeltranANDNemesisSierra.entidades;
using JorgeBeltranANDNemesisSierra.recursos;

namespace JorgeBeltranANDNemesisSierra.vistas
{
    public partial class FrmVentas : Form
    {
        ControlVentas controlventas = new ControlVentas();
        int sel;
        public String idSel = "";
        Ventas venta = new Ventas();
        public FrmVentas()
        {
            InitializeComponent();
            controlventas.llenartablaVenta(DgvVentas);            
        }

        public void Calculo()
        {
            if (TbxPrecio.Text != "")
            {
                if (TbxCantidad.Text != "")
                {
                    int precio = (Convert.ToInt32(TbxPrecio.Text));
                    int cantidad = (Convert.ToInt32(TbxCantidad.Text));
                    int total = precio * cantidad;
                    TbxTotal.Text = total.ToString();
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbxID.Text = "";
            TbxCantidad.Text = "";
            TbxPrecio.Text = "";
            TbxTotal.Text = "";
            TbxProducto.Text = "";
            TbxFechaVenta.Text = "";
            TbxNomCliente.Text = "";
            TbxUsuario.Text = "";
        }

        private void DgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel = e.RowIndex;
            idSel = DgvVentas.Rows[sel].Cells[0].Value.ToString();
            TbxID.Text = DgvVentas.Rows[sel].Cells[0].Value.ToString();
            TbxCantidad.Text = DgvVentas.Rows[sel].Cells[1].Value.ToString();
            TbxPrecio.Text = DgvVentas.Rows[sel].Cells[2].Value.ToString();
            TbxTotal.Text = DgvVentas.Rows[sel].Cells[3].Value.ToString();
            TbxProducto.Text = DgvVentas.Rows[sel].Cells[4].Value.ToString();
            TbxFechaVenta.Text = DgvVentas.Rows[sel].Cells[5].Value.ToString();
            TbxNomCliente.Text = DgvVentas.Rows[sel].Cells[6].Value.ToString();
            TbxUsuario.Text = DgvVentas.Rows[sel].Cells[7].Value.ToString();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            controlventas.llenartablaVenta(DgvVentas);
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            if (TbxCantidad.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La cantidad no puede estar vacía.";
            }
            if (TbxPrecio.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El precio no puede estar vacío.";
            }
            if (TbxTotal.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El total no puede estar vacío.";
            }
            if (TbxProducto.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El producto no puede estar vacío.";
            }
            if (TbxFechaVenta.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La fecha de venta no puede estar vacía.";
            }
            if (TbxNomCliente.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El nombre del cliente no puede estar vacío.";
            }
            if (TbxUsuario.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El usuario no puede estar vacía.";
            }
            if (Sesiones.mensajeError == "")
            {
                venta.Cantidad = Convert.ToInt32(TbxCantidad.Text);
                venta.Precio = Convert.ToInt32(TbxPrecio.Text);
                venta.Total = Convert.ToInt32(TbxTotal.Text);
                venta.Producto = TbxProducto.Text;
                venta.FechaVenta = TbxFechaVenta.Text;
                venta.NomCliente = TbxNomCliente.Text;
                venta.Usuario = TbxUsuario.Text;
                controlventas.insertarVenta(venta, DgvVentas);
            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (TbxCantidad.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La cantidad no puede estar vacía.";
            }
            if (TbxPrecio.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El precio no puede estar vacío.";
            }
            if (TbxTotal.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El total no puede estar vacío.";
            }
            if (TbxProducto.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El producto no puede estar vacío.";
            }
            if (TbxFechaVenta.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La fecha de venta no puede estar vacía.";
            }
            if (TbxNomCliente.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El nombre del cliente no puede estar vacío.";
            }
            if (TbxUsuario.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El usuario no puede estar vacía.";
            }
            if (Sesiones.mensajeError == "")
            {
                venta.Cantidad = Convert.ToInt32(TbxCantidad.Text);
                venta.Precio = Convert.ToInt32(TbxPrecio.Text);
                venta.Total = Convert.ToInt32(TbxTotal.Text);
                venta.Producto = TbxProducto.Text;
                venta.FechaVenta = TbxFechaVenta.Text;
                venta.NomCliente = TbxNomCliente.Text;
                venta.Usuario = TbxUsuario.Text;
                venta.Idventas = Convert.ToInt32(idSel);
                controlventas.insertarVenta(venta, DgvVentas);
            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TbxCantidad.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La cantidad no puede estar vacía.";
            }
            if (TbxPrecio.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El precio no puede estar vacío.";
            }
            if (TbxTotal.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El total no puede estar vacío.";
            }
            if (TbxProducto.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El producto no puede estar vacío.";
            }
            if (TbxFechaVenta.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La fecha de venta no puede estar vacía.";
            }
            if (TbxNomCliente.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El nombre del cliente no puede estar vacío.";
            }
            if (TbxUsuario.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El usuario no puede estar vacía.";
            }
            if (Sesiones.mensajeError == "")
            {
                venta.Cantidad = Convert.ToInt32(TbxCantidad.Text);
                venta.Precio = Convert.ToInt32(TbxPrecio.Text);
                venta.Total = Convert.ToInt32(TbxTotal.Text);
                venta.Producto = TbxProducto.Text;
                venta.FechaVenta = TbxFechaVenta.Text;
                venta.NomCliente = TbxNomCliente.Text;
                venta.Usuario = TbxUsuario.Text;
                venta.Idventas = Convert.ToInt32(idSel);
                controlventas.insertarVenta(venta, DgvVentas);
            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Calculo();
        }
    }
}
