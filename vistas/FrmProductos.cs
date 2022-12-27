using System;
using System.Data;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using JorgeBeltranANDNemesisSierra.control;
using JorgeBeltranANDNemesisSierra.entidades;
using JorgeBeltranANDNemesisSierra.recursos;

namespace JorgeBeltranANDNemesisSierra.vistas
{
    //----------------------------------------------------------------------------------
    //Formulario para catalógo de productos.
    //----------------------------------------------------------------------------------
    public partial class FrmProductos : Form
    {
        ControlProductos controlprod = new ControlProductos();
        Productos productos = new Productos();
        public String idSel = "";
        int sel;
        public FrmProductos()
        {
            InitializeComponent();
            controlprod.ActualizarTabla(DgvProductos);
            DgvProductos.Columns[5].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProductos.AutoResizeColumns();
        }
        //----------------------------------------------------------------------------------
        //Botón para actualizar la información de la bases de datos de productos.
        //----------------------------------------------------------------------------------
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            controlprod.ActualizarTabla(DgvProductos);
        }
        //----------------------------------------------------------------------------------
        //Botón para insertar productos en la base de datos.
        //----------------------------------------------------------------------------------
        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            if (TbxNombreProd.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + mensajes.Errores.nombreProduc;
            }
            if (TbxPrecioCompra.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + mensajes.Errores.PrecioCompra;
            }
            if (TbxPrecioVenta.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + mensajes.Errores.PrecioVenta;
            }
            if (TbxCodigo.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + mensajes.Errores.Codigo;
            }
            if (TbxDescripcion.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + mensajes.Errores.Descripcion;
            }
            if (Sesiones.mensajeError == "")
            {
                productos.NombreProducto = TbxNombreProd.Text;
                productos.PrecioCompra = Convert.ToInt32(TbxPrecioCompra.Text);
                productos.PrecioVenta = Convert.ToInt32(TbxPrecioVenta.Text);
                productos.Codigo = Convert.ToInt32(TbxCodigo.Text);
                productos.Descripcion = TbxDescripcion.Text;
                controlprod.InsertarProducto(productos, DgvProductos);
            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }            
        }
        //----------------------------------------------------------------------------------
        //Evento al dar click en alguna celda y obtener la información, y ponerla en los textbox.
        //----------------------------------------------------------------------------------
        private void DgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel = e.RowIndex;
            idSel = DgvProductos.Rows[sel].Cells[0].Value.ToString();
            TbxID.Text = DgvProductos.Rows[sel].Cells[0].Value.ToString();
            TbxNombreProd.Text = DgvProductos.Rows[sel].Cells[1].Value.ToString();
            TbxPrecioCompra.Text = DgvProductos.Rows[sel].Cells[2].Value.ToString();
            TbxPrecioVenta.Text = DgvProductos.Rows[sel].Cells[3].Value.ToString();
            TbxCodigo.Text = DgvProductos.Rows[sel].Cells[4].Value.ToString();
            TbxDescripcion.Text = DgvProductos.Rows[sel].Cells[5].Value.ToString();
        }
        //----------------------------------------------------------------------------------
        //Botón para comprobar los campos y hacer modificación a los productos.
        //----------------------------------------------------------------------------------
        private void BtnModificar_Click(object sender, EventArgs e)
        {    
            if (TbxNombreProd.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + mensajes.Errores.nombreProduc;
            }
            if (TbxPrecioCompra.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + mensajes.Errores.PrecioCompra;
            }
            if (TbxPrecioVenta.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + mensajes.Errores.PrecioVenta;
            }
            if (TbxCodigo.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + mensajes.Errores.Codigo;
            }
            if (TbxDescripcion.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + mensajes.Errores.Descripcion;
            }
            if (Sesiones.mensajeError == "")
            {
                productos.NombreProducto = TbxNombreProd.Text;
                productos.PrecioCompra = Convert.ToInt32(TbxPrecioCompra.Text);
                productos.PrecioVenta = Convert.ToInt32(TbxPrecioVenta.Text);
                productos.Codigo = Convert.ToInt32(TbxCodigo.Text);
                productos.Descripcion = TbxDescripcion.Text;
                productos.IdProducto1 = Convert.ToInt32(idSel);
                controlprod.ModificarProducto(productos, DgvProductos);
            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }
        }
        //----------------------------------------------------------------------------------
        //Botón para comprobar los campos y hacer eliminación a los productos.
        //----------------------------------------------------------------------------------
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TbxNombreProd.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + mensajes.Errores.nombreProduc;
            }
            if (TbxPrecioCompra.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + mensajes.Errores.PrecioCompra;
            }
            if (TbxPrecioVenta.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + mensajes.Errores.PrecioVenta;
            }
            if (TbxCodigo.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + mensajes.Errores.Codigo;
            }
            if (TbxDescripcion.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + mensajes.Errores.Descripcion;
            }
            if (Sesiones.mensajeError == "")
            {
                productos.NombreProducto = TbxNombreProd.Text;
                productos.PrecioCompra = Convert.ToInt32(TbxPrecioCompra.Text);
                productos.PrecioVenta = Convert.ToInt32(TbxPrecioVenta.Text);
                productos.Codigo = Convert.ToInt32(TbxCodigo.Text);
                productos.Descripcion = TbxDescripcion.Text;
                productos.IdProducto1 = Convert.ToInt32(idSel);
                controlprod.EliminarProducto(productos, DgvProductos);
            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }
        }
        //----------------------------------------------------------------------------------
        //Evento del mouse click derecho sobre la tabla para borrar y mostrar los datos.
        //Pendiente.
        //----------------------------------------------------------------------------------
        private void DgvProductos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
                int posicion = DgvProductos.HitTest(e.X, e.Y).RowIndex;
                if (posicion > -1)
                {
                    menu.Items.Add("Borrar").Name = "Borrar" + posicion;
                    menu.Items.Add("Mostrar").Name = "Mostrar" + posicion;
                }
                menu.Show(DgvProductos, e.X, e.Y);
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
                idSel = DgvProductos.Rows[int.Parse(id2)].Cells[0].Value.ToString();
                Borrar(int.Parse(idSel));
            }if (id2.Contains("Mostrar"))
            {
                id2 = id2.Replace("Mostrar", "");
                Mostrar(int.Parse(id2));
            }
        }
        //Mostrar MessageBox con la información del producto.
        private void Mostrar(int idMostrar)
        {
            String res = "ID del producto = " + DgvProductos.Rows[idMostrar].Cells[0].Value.ToString() + "\n";
            res = res + "Nombre del producto = " + DgvProductos.Rows[idMostrar].Cells[1].Value.ToString() + "\n";
            res = res + "Precio de Compra = " + DgvProductos.Rows[idMostrar].Cells[2].Value.ToString() + "\n";
            res = res + "Precio de Venta = " + DgvProductos.Rows[idMostrar].Cells[3].Value.ToString() + "\n";
            res = res + "Código del producto = " + DgvProductos.Rows[idMostrar].Cells[4].Value.ToString() + "\n";
            res = res + "Descripción del producto = " + DgvProductos.Rows[idMostrar].Cells[5].Value.ToString() + "\n";
            MessageBox.Show(res);
        }

        private void Borrar(int idBorrar)
        {
          controlprod.EliminarSelc(idBorrar, DgvProductos);            
        }
        //Limpiar los campos de texto.
        //----------------------------------------------------------------------------------
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbxID.Text = "";
            TbxNombreProd.Text = "";
            TbxPrecioVenta.Text = "";
            TbxPrecioCompra.Text = "";
            TbxCodigo.Text = "";
            TbxDescripcion.Text = "";
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteProductos produ = new FrmReporteProductos();
            produ.ShowDialog();
        }
        
        private void TbxNombreProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar >= 31 && e.KeyChar <= 64 || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }*/
            Validar.SoloLetras(e);
        }

        private void TbxCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }*/
            Validar.SoloNumeros(e);
        }
    }
}
