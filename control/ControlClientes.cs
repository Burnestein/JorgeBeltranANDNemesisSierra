using System;
using MySql.Data.MySqlClient;
using JorgeBeltranANDNemesisSierra.entidades;
using System.Windows.Forms;

namespace JorgeBeltranANDNemesisSierra.control
{
    //----------------------------------------------------------------------------------
    //Clase para operaciones CRUD de clientes y operar la información.
    //----------------------------------------------------------------------------------
    public class ControlClientes : Conexion
    {
        MySqlCommand Query = new MySqlCommand();//Para preparar la consulta y guardar los datos
        MySqlDataReader consultar;//Para consultar a la base
        //----------------------------------------------------------------------------------
        //Método para eliminar clientes.
        //----------------------------------------------------------------------------------
        public void eliminarCliente(Clientes cliente, DataGridView dataGridView)
        {
            conectar();
            string query = "delete from tblclientes where id='" + cliente.Idcliente + "';";
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
                llenartablaClientes(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //----------------------------------------------------------------------------------
        //Método para consultar clientes.
        //----------------------------------------------------------------------------------
        public void consultarCliente(Clientes cliente, DataGridView dataGridView)
        {
            conectar();
            string query = "update tblclientes set " +
                "nombre='" + cliente.Nombre + "', apepat='" + cliente.Apepat + "'," +
                "apemat='" + cliente.Apemat + "', domicilio='" + cliente.Domicilio + "', colonia='" + cliente.Colonia
                + "', telefono='" + cliente.Telefono + "', limitecredito='" + cliente.Limitecredito 
                + "' where id='" + cliente.Idcliente + "';";
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
                llenartablaClientes(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //----------------------------------------------------------------------------------
        //Método para registrar clientes.
        //----------------------------------------------------------------------------------
        public void registrarCliente(Clientes cliente, DataGridView dataGridView)
        {
            conectar();
            string query = "insert into tblclientes " +
                "(nombre, apepat, apemat, domicilio, colonia,telefono, limitecredito)values " +
                "('" + cliente.Nombre + "', '" + cliente.Apepat + "', '" + cliente.Apemat + "'" +
                ",'" + cliente.Domicilio + "','" + cliente.Colonia + "','" + cliente.Telefono + "'" +
                ",'" + cliente.Limitecredito + "')";
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
                llenartablaClientes(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        public void llenaCombo(ComboBox combo)
        {
            try
            {
                Query = new MySqlCommand(
                    "Select * from tblusuarios",
                    conectar());
                Query.Prepare();

                consultar = Query.ExecuteReader();
                while (consultar.Read())
                {
                    combo.Items.Add(consultar["usuario"].ToString());
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
        }//Método para llenar box
        //----------------------------------------------------------------------------------
        //Método para actualizar la tabla de clientes.
        //----------------------------------------------------------------------------------
        public void llenartablaClientes(DataGridView tabla)
        {
            try
            {
                Query = new MySqlCommand("Select * from tblclientes",
                    conectar());
                Query.Prepare();

                consultar = Query.ExecuteReader();
                tabla.Rows.Clear();
                while (consultar.Read())
                {
                        tabla.Rows.Add(consultar["id"].ToString(),
                        consultar["nombre"].ToString(),
                        consultar["apepat"].ToString(),
                        consultar["apemat"].ToString(),
                        consultar["domicilio"].ToString(),
                        consultar["colonia"].ToString(),
                        consultar["telefono"].ToString(),
                        consultar["limitecredito"].ToString());
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
