using System.Windows.Forms;
using JorgeBeltranANDNemesisSierra.entidades;
using JorgeBeltranANDNemesisSierra.recursos;
using MySql.Data.MySqlClient;

namespace JorgeBeltranANDNemesisSierra.control
{
    public class ControlUsuarios : Conexion
    {
        MySqlCommand Query = new MySqlCommand();//Para preparar la consulta y guardar los datos
        MySqlDataReader consultar;//Para consultar a la base
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
        public void registrarUsuario(Usuario usuario)
        {

        }
        public void eliminarUsuario(Usuario usuario)
        {

        }
        public void modificarUsuario(Usuario usuario)
        {

        }
    }
}
