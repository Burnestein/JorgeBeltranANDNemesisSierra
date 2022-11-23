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
        public void eliminarVenta(Ventas venta, DataGridView dataGridView)
        {
            conectar();
            string query = "delete from tblventas where id='" + venta.Idventas + "';";
            MySqlCommand command = new MySqlCommand(query, Conexion.con);
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                desconectar();
                MessageBox.Show("Eliminación exitosa.");
                dataGridView.Rows.Clear();
                dataGridView.Refresh();
                llenartablaVenta(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //----------------------------------------------------------------------------------
        //Método para modificar ventas.
        //----------------------------------------------------------------------------------
        public void modificarVenta(Ventas venta, DataGridView dataGridView)
        {
            conectar();
            string query = "update tblventas set " +
                "cantidad='" + venta.Cantidad + "', precio='" + venta.Precio + "'," +
                "total='" + venta.Total + "', producto='" + venta.Producto + "', fecha_venta='" + venta.FechaVenta
                + "', nom_cliente='" + venta.NomCliente + "', nom_usuario='" + venta.Usuario
                + "' where id='" + venta.Idventas + "';";
            MySqlCommand command = new MySqlCommand(query, Conexion.con);
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                desconectar();
                MessageBox.Show("Modificación exitosa.");
                dataGridView.Rows.Clear();
                dataGridView.Refresh();
                llenartablaVenta(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //----------------------------------------------------------------------------------
        //Método para registrar ventas.
        //----------------------------------------------------------------------------------
        public void insertarVenta(Ventas venta, DataGridView dataGridView)
        {
            conectar();
            string query = "insert into tblventas " +
                "(cantidad, precio, total, producto, fecha_venta, nom_cliente, nom_usuario)values " +
                "('" + venta.Cantidad + "', '" + venta.Precio + "', '" + venta.Total + "'" +
                ",'" + venta.Producto + "','" + venta.FechaVenta + "','" + venta.NomCliente + "'" +
                ",'" + venta.Usuario + "')";
            MySqlCommand command = new MySqlCommand(query, Conexion.con);
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                desconectar();
                MessageBox.Show("Registro exitoso.");
                dataGridView.Rows.Clear();
                dataGridView.Refresh();
                llenartablaVenta(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }        
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
    }

}
