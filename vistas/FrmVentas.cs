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
        int bandera = 0;
        public FrmVentas()
        {
            InitializeComponent();
            controlventas.llenaCombo(CbxProductos);
        }
        /*
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
        */
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbxCantidad.Text = "";
            CbxProductos.SelectedItem= "Triki Trakes";
        }

        private void DgvVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel = e.RowIndex;
            CbxProductos.Text = DgvVentas.Rows[sel].Cells[0].Value.ToString();
            TbxCantidad.Text = DgvVentas.Rows[sel].Cells[1].Value.ToString();
        }
        /*
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
            if (Sesiones.mensajeError == "")
            {
                venta.Cantidad = Convert.ToInt32(TbxCantidad.Text);
                venta.Precio = Convert.ToInt32(TbxPrecio.Text);
                venta.Total = Convert.ToInt32(TbxTotal.Text);
                venta.Producto = TbxProducto.Text;
                venta.FechaVenta = TbxFechaVenta.Text;
                venta.NomCliente = TbxNomCliente.Text;
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
            if (Sesiones.mensajeError == "")
            {
                venta.Cantidad = Convert.ToInt32(TbxCantidad.Text);
                venta.Precio = Convert.ToInt32(TbxPrecio.Text);
                venta.Total = Convert.ToInt32(TbxTotal.Text);
                venta.Producto = TbxProducto.Text;
                venta.FechaVenta = TbxFechaVenta.Text;
                venta.NomCliente = TbxNomCliente.Text;
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
            if (Sesiones.mensajeError == "")
            {
                venta.Cantidad = Convert.ToInt32(TbxCantidad.Text);
                venta.Precio = Convert.ToInt32(TbxPrecio.Text);
                venta.Total = Convert.ToInt32(TbxTotal.Text);
                venta.Producto = TbxProducto.Text;
                venta.FechaVenta = TbxFechaVenta.Text;
                venta.NomCliente = TbxNomCliente.Text;
                venta.Idventas = Convert.ToInt32(idSel);
                controlventas.insertarVenta(venta, DgvVentas);
            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }
        }
        */
             
        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            String valor = CbxProductos.Text.ToString();
            String suma_Total;
            int acum = 0;

            venta.Producto = valor;
            venta.Cantidad = Convert.ToInt32(TbxCantidad.Text);

            venta.Precio = controlventas.Precios(venta.Producto);
            venta.Subtotal = Convert.ToInt32(venta.Precio * venta.Cantidad);
            venta.Iva = Convert.ToInt32(venta.Subtotal * 0.16);
            venta.Total = Convert.ToInt32(venta.Subtotal + venta.Iva);

            DgvVentas.Rows.Add(venta.Producto.ToString(),
                    venta.Cantidad.ToString(),
                    venta.Precio.ToString(),
                     venta.Subtotal.ToString(),
                     venta.Iva.ToString(),
                   venta.Total.ToString());

            for (int i=0; i<=bandera; i++)
            {
                suma_Total = DgvVentas.Rows[i].Cells[5].Value.ToString();
                acum += Convert.ToInt32(suma_Total);
            }
            TbxTotal.Text = acum.ToString();
            bandera += 1;
        }

    }
}
