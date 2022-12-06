﻿using System;
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
            controlventas.llenaCombo(CbxProductos);
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
            MessageBox.Show("El nombre es: " + CbxProductos.Text.ToString());
            String valor = CbxProductos.Text.ToString();            

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
        }
    }
}
