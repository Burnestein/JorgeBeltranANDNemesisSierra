using System.Windows.Forms;
using JorgeBeltranANDNemesisSierra.entidades;
using JorgeBeltranANDNemesisSierra.recursos;
using MySql.Data.MySqlClient;
using System;

namespace JorgeBeltranANDNemesisSierra.control
{
    //----------------------------------------------------------------------------------
    //Clase para operaciones CRUD de proveedores y operar la información.
    //----------------------------------------------------------------------------------
    public class controlProveedores : Conexion
    {
        MySqlCommand Query = new MySqlCommand();//Para preparar la consulta y guardar los datos
        MySqlDataReader consultar;//Para consultar a la base        
        //----------------------------------------------------------------------------------
        //Método para actualizar tabla de proveedores.
        //----------------------------------------------------------------------------------
        public void actualizarTabla(DataGridView tabla)
        {
            try
            {
                Query = new MySqlCommand("Select * from tblproveedores",
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
                        consultar["empresa"].ToString(),
                        consultar["colonia"].ToString(),
                        consultar["telefono"].ToString(),
                        consultar["correo"].ToString());
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
        //----------------------------------------------------------------------------------
        //Método para registrar proveedores.
        //----------------------------------------------------------------------------------
        public void registrarProveedores(Proveedores Proveedores, DataGridView dataGridView)
        {
            conectar();
            string query = "insert into tblproveedores " +
                "(nombre, apepat, apemat, domicilio, empresa, colonia, telefono, correo)values " +
                "('" + Proveedores.Nombre + "', '" + Proveedores.Apepat + "', '" + Proveedores.Apemat + "'" +
                ",'" + Proveedores.Domicilio + "','" + Proveedores.Empresa + "','" + Proveedores.Colonia + "'" +
                ",'" + Proveedores.Telefono + "','" + Proveedores.Correo + "')";
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
                actualizarTabla(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //----------------------------------------------------------------------------------
        //Método para eliminar proveedores.
        //----------------------------------------------------------------------------------
        public void eliminarProveedores(Proveedores Proveedores, DataGridView dataGridView)
        {
            conectar();
            string query = "delete from tblproveedores where id='" + Proveedores.IdProveedor + "';";
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
                actualizarTabla(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //----------------------------------------------------------------------------------
        //Método para modificar proveedores.
        //----------------------------------------------------------------------------------
        public void modificarProveedores(Proveedores Proveedores, DataGridView dataGridView)
        {
            conectar();
            string query = "update tblproveedores set " +
                "nombre='" + Proveedores.Nombre + "',apepat='" + Proveedores.Apepat + "'," +
                "apemat='" + Proveedores.Apemat + "', domicilio='" + Proveedores.Domicilio + "'," +
                "empresa='" + Proveedores.Empresa + "', colonia='" + Proveedores.Colonia + "', telefono='" + Proveedores.Telefono
                + "', correo='" + Proveedores.Correo + "' where id='" + Proveedores.IdProveedor + "';";
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
                actualizarTabla(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EliminarSelc(int idBorrar, DataGridView dataGridView)
        {
            conectar();
            string query = "delete from tblproveedores where id='" + idBorrar + "';";
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
                actualizarTabla(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

        
}
