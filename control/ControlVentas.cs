using System.Windows.Forms;
using JorgeBeltranANDNemesisSierra.entidades;
using JorgeBeltranANDNemesisSierra.recursos;
using MySql.Data.MySqlClient;
using System;

namespace JorgeBeltranANDNemesisSierra.control
{
    //----------------------------------------------------------------------------------
    //Clase para operaciones CRUD de ventas y operar la información.
    //----------------------------------------------------------------------------------
    public class ControlVentas : Conexion
    {
        MySqlCommand Query = new MySqlCommand();//Para preparar la consulta y guardar los datos
        MySqlDataReader consultar;//Para consultar a la base
        //----------------------------------------------------------------------------------
        //Método para eliminar ventas.
        //----------------------------------------------------------------------------------
        
        
        //----------------------------------------------------------------------------------
        //Método para actualizar la tabla de ventas.
        //----------------------------------------------------------------------------------
        public void llenartablaVenta(DataGridView tabla)
        {
            try
            {
                Query = new MySqlCommand("Select * from tblventas",
                    conectar());
                Query.Prepare();

                consultar = Query.ExecuteReader();
                tabla.Rows.Clear();
                while (consultar.Read())
                {
                    tabla.Rows.Add(consultar["id"].ToString(),
                    consultar["cantidad"].ToString(),
                    consultar["precio"].ToString(),
                    consultar["total"].ToString(),
                    consultar["producto"].ToString(),
                    consultar["fecha_venta"].ToString(),
                    consultar["nom_cliente"].ToString(),
                    consultar["nom_usuario"].ToString());
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                desconectar();
            }
        }

        public void llenaCombo(ComboBox combo)
        {
            try
            {
                Query = new MySqlCommand(
                    "Select nombreProducto from tblproductos",
                    conectar());
                Query.Prepare();

                consultar = Query.ExecuteReader();
                
                while (consultar.Read())
                {
                    consultar.Read();
                    combo.Items.Add(consultar["nombreProducto"].ToString());
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                desconectar();
            }
        }

        public int Precios(String nombreProducto)
        {
            int precio = 0;
            try
            {
                Query = new MySqlCommand("Select precioVenta from tblproductos where nombreProducto='" + nombreProducto + "';",
                    conectar());
                Query.Prepare();

                consultar = Query.ExecuteReader();
                while (consultar.Read())
                {
                    precio = Convert.ToInt32(consultar["precioVenta"].ToString());
                }
                MessageBox.Show("El precio es : " + precio);
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                desconectar();
            }
            return precio;
        }

    }
}
