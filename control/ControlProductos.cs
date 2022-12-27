using MySql.Data.MySqlClient;
using JorgeBeltranANDNemesisSierra.entidades;
using System.Windows.Forms;
using System;

namespace JorgeBeltranANDNemesisSierra.control
{
    //----------------------------------------------------------------------------------
    //Clase para operaciones CRUD de productos y operar la información.
    //----------------------------------------------------------------------------------
    public class ControlProductos 
    {
        //----------------------------------------------------------------------------------
        //Atributos
        //----------------------------------------------------------------------------------
        Conexion conexion = new Conexion();
        //----------------------------------------------------------------------------------
        //Método para obtener los datos de la base de datos y mostrarlo en la tabla.
        //----------------------------------------------------------------------------------
        public void ActualizarTabla(DataGridView dataGridView)
        {
            conexion.conectar();
            string query = "select * from tblproductos;";
            MySqlCommand command = new MySqlCommand(query, Conexion.con);
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dataGridView.Rows.Clear();
                    while (reader.Read())
                    {
                        int n = dataGridView.Rows.Add();
                        dataGridView.Rows[n].Cells[0].Value = reader.GetString(0);
                        dataGridView.Rows[n].Cells[1].Value = reader.GetString(1);
                        dataGridView.Rows[n].Cells[2].Value = reader.GetString(2);
                        dataGridView.Rows[n].Cells[3].Value = reader.GetString(3);
                        dataGridView.Rows[n].Cells[4].Value = reader.GetString(4);
                        dataGridView.Rows[n].Cells[5].Value = reader.GetString(5);
                    }
                }
                else
                {
                    MessageBox.Show("No hay trabajadores.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //----------------------------------------------------------------------------------
        //Método para insertar productos en la base de datos.
        //----------------------------------------------------------------------------------
        public void InsertarProducto(Productos productos, DataGridView dataGridView)
        {
            conexion.conectar();
            string query = "insert into tblproductos " +
                "(nombreProducto, precioCompra, precioVenta, codigo, descripcion)values " +
                "('" + productos.NombreProducto +"', '"+ productos.PrecioCompra +"', '"+productos.PrecioVenta+"'" +
                ",'"+productos.Codigo+"','"+ productos.Descripcion+"')";
            MySqlCommand command = new MySqlCommand(query, Conexion.con);
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                conexion.desconectar();
                MessageBox.Show("Registro exitoso.");
                dataGridView.Rows.Clear();
                dataGridView.Refresh();
                ActualizarTabla(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //----------------------------------------------------------------------------------
        //Método para modificar productos en la base de datos.
        //----------------------------------------------------------------------------------
        public void ModificarProducto(Productos productos, DataGridView dataGridView)
        {
            conexion.conectar();
            string query = "update tblproductos set " +
                "nombreProducto='"+productos.NombreProducto+"',precioCompra='"+ productos.PrecioCompra +"'," +
                "precioVenta='"+ productos.PrecioVenta+"', codigo='"+ productos.Codigo+"'," +
                "descripcion='"+ productos.Descripcion+"' where id='"+ productos.IdProducto1 +"';";
            MySqlCommand command = new MySqlCommand(query, Conexion.con);
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                conexion.desconectar();
                MessageBox.Show("Modificación exitosa.");
                dataGridView.Rows.Clear();
                dataGridView.Refresh();
                ActualizarTabla(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //----------------------------------------------------------------------------------
        //Método para eliminar productos seleccionados en la base de datos.
        //----------------------------------------------------------------------------------
        public void EliminarProducto(Productos productos, DataGridView dataGridView)
        {
            conexion.conectar();
            string query = "delete from tblproductos where id='" + productos.IdProducto1 + "';";
            MySqlCommand command = new MySqlCommand(query, Conexion.con);
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                conexion.desconectar();
                MessageBox.Show("Eliminación exitosa.");
                dataGridView.Rows.Clear();
                dataGridView.Refresh();
                ActualizarTabla(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void EliminarSelc(int idMostrar, DataGridView dataGridView)
        {
            conexion.conectar();
            string query = "delete from tblproductos where id='" + idMostrar + "';";
            MySqlCommand command = new MySqlCommand(query, Conexion.con);
            command.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = command.ExecuteReader();
                conexion.desconectar();
                MessageBox.Show("Eliminación exitosa.");
                dataGridView.Rows.Clear();
                dataGridView.Refresh();
                ActualizarTabla(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
