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
        String username = Form1.nameuser;
        public FrmVentas()
        {
            InitializeComponent();
            //Llenar el comboBox con los datos de la base de datos.
            controlventas.llenaCombo(CbxProductos);
            //Insertar fecha actual
            TbxFechaVenta.Text = DateTime.UtcNow.ToString("MM-dd-yyyy");
            //Insertar el username guardado desde la ventana Login.
            TbxUsername.Text = username;
        }
       
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbxCantidad.Text = "";
            CbxProductos.SelectedItem= "";
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
            String valor = "";
            if (CbxProductos.Text != "" && TbxCantidad.Text != "")
            {
                valor = CbxProductos.Text.ToString();

                String suma_Total;
                int acum = 0;
                //El objeto creado de la clase venta, insertar los datos que necesitamos.
                venta.Producto = valor;
                venta.Cantidad = Convert.ToInt32(TbxCantidad.Text);
                //Con el nombre del producto, obtener en la base de datos el precio de venta.
                venta.Precio = controlventas.Precios(venta.Producto);
                //Calcular el subtotal multiplicando el valor del precio venta por la cantidad.
                venta.Subtotal = Convert.ToInt32(venta.Precio * venta.Cantidad);
                //Calcular el IVA del subtotal del precio.
                venta.Iva = Convert.ToInt32(venta.Subtotal * 0.16);
                //Sumar el subtotal mas el IVA, para obtener el precio total.
                venta.Total = Convert.ToInt32(venta.Subtotal + venta.Iva);
                //Una vez completado los datos que necesita el objeto, insertarlo en la tabla en una fila.
                //Llenar la tabla con los datos generados.
                /*nombreProducto || Cantidad || Precio || Subtotal || IVA || Total*/
                DgvVentas.Rows.Add(venta.Producto.ToString(),
                        venta.Cantidad.ToString(),
                        venta.Precio.ToString(),
                         venta.Subtotal.ToString(),
                         venta.Iva.ToString(),
                       venta.Total.ToString());
                //Sumar el precio total de todos los artículos de una venta.
                for (int i = 0; i <= bandera; i++)
                {
                    suma_Total = DgvVentas.Rows[i].Cells[5].Value.ToString();
                    acum += Convert.ToInt32(suma_Total);
                }
                //Insertar el precio total en un tbx.
                TbxTotal.Text = "$" + acum.ToString() + " MXN";
                /*Variable para indicar el número de productos insertados y ejecutar el for,
                para realizar la suma de precios totales de los productos de una venta.*/
                bandera += 1;
            }
            else
            {
                if (TbxCantidad.Text == "")
                {
                    MessageBox.Show("No puedes dejar vacío este campo de cantidad.");
                } if (CbxProductos.Text == "")
                {
                    MessageBox.Show("No puedes dejar vacío el producto a seleccionar.");
                }
            }
        }

        private void TbxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TbxNomCliente_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }*/
            Validar.SoloLetras(e);
        }

    }
}
