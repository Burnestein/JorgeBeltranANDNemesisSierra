using System.Windows.Forms;
using JorgeBeltranANDNemesisSierra.entidades;
using JorgeBeltranANDNemesisSierra.recursos;
using MySql.Data.MySqlClient;
using System;

namespace JorgeBeltranANDNemesisSierra.control

{
    //----------------------------------------------------------------------------------
    //Clase para operaciones CRUD de usuarios y operar la información.
    //----------------------------------------------------------------------------------
    public class ControlUsuarios : Conexion
    {
        MySqlCommand Query = new MySqlCommand();//Para preparar la consulta y guardar los datos
        MySqlDataReader consultar;//Para consultar a la base

        //----------------------------------------------------------------------------------
        //Método para validar usuarios.
        //----------------------------------------------------------------------------------
        public byte ValidarUsuarios(Usuario usuario)
        {
            byte existe = 0;
            try
            {
                Query = new MySqlCommand(               //La consulta a la base de datos.
                    "SELECT * FROM tblusuarios " +        //Para verificar si encuentra
                    "WHERE usuario=@username " +         //usuario y contraseña.
                    "AND contra=@passwd",
                    conectar());
                Query.Prepare();
                Query.Parameters.AddWithValue("@username", usuario.Usuarios);
                Query.Parameters.AddWithValue("@passwd", usuario.Contra);
                consultar = Query.ExecuteReader();
                consultar.Read();//Ejecutar
                if (consultar.HasRows)
                {
                    string name = consultar["contra"].ToString();
                    Sesiones.nomusuario = usuario.Usuarios.ToString() + " " + name;
                    existe = 1;
                }
                else
                {
                    MessageBox.Show("usuario o contraseña no válidos.");
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
            return existe;
        }
        //----------------------------------------------------------------------------------
        //Método para actualizar usuarios.
        //----------------------------------------------------------------------------------
        public void actualizarTabla(DataGridView tabla)
        {            
                try
                {
                    Query = new MySqlCommand("Select * from tblusuarios",
                        conectar());
                    Query.Prepare();

                    consultar = Query.ExecuteReader();
                    tabla.Rows.Clear();
                    while (consultar.Read())
                    {
                        tabla.Rows.Add(consultar["id"].ToString(),
                            consultar["usuario"].ToString(),
                            consultar["contra"].ToString(),
                            consultar["nombre"].ToString(),
                            consultar["apepat"].ToString(),
                            consultar["apemat"].ToString(),
                            consultar["calle"].ToString(),
                            consultar["numero"].ToString(),
                            consultar["colonia"].ToString(),
                            consultar["estado"].ToString(),
                            consultar["numCelular"].ToString());
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
        //Método para registrar usuarios.
        //----------------------------------------------------------------------------------
        public void registrarUsuario(Usuario usuario, DataGridView dataGridView)
        {
            conectar();
            string query = "insert into tblusuarios " +
                "(usuario, contra, nombre, apepat, apemat, calle, numero, colonia, estado, numCelular)values " +
                "('" + usuario.Usuarios + "', '" + usuario.Contra + "', '" + usuario.Nombre + "'" +
                ",'" + usuario.Apepat + "','" + usuario.Apemat + "','" + usuario.Calle + "'" +
                ",'" + usuario.Numero + "','" + usuario.Colonia + "','" + usuario.Estado + "'" +
                ",'" + usuario.Numcelular + "')";
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
        //Método para eliminar usuarios.
        //----------------------------------------------------------------------------------
        public void eliminarUsuario(Usuario usuario, DataGridView dataGridView)
        {
            conectar();
            string query = "delete from tblusuarios where id='" + usuario.UsuarioID + "';";
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
        //Método para modificar usuarios.
        //----------------------------------------------------------------------------------
        public void modificarUsuario(Usuario usuario, DataGridView dataGridView)
        {
            conectar();
            string query = "update tblusuarios set " +
                "usuario='" + usuario.Usuarios + "',contra='" + usuario.Contra + "'," +
                "nombre='" + usuario.Nombre + "', apepat='" + usuario.Apepat + "'," +
                "apemat='" + usuario.Apemat + "', calle='" + usuario.Calle + "', numero='" + usuario.Numero
                + "', colonia='" + usuario.Colonia + "', estado='" + usuario.Estado + "', numCelular='" + usuario.Numcelular 
                + "' where id='" + usuario.UsuarioID + "';";
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

    }
}
