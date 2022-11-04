using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace JorgeBeltranANDNemesisSierra.control
{
    public class Conexion
    {   // Probando cambios en Github

        public static string servidor = "localhost"; //Nombre o ip del servidor de MySQL
        public static string bd = "bdtiendita"; // Nombre de la base de datos
        public static string usuario = "root"; //Usuario de acceso a MySQL
        public static string password = ""; //Contraseña de usuario de acceso a MySQL
                                           //Crearemos la cadena de conexion concatenando las variables        
        public static string cadenaConexion = "Database=" + bd + "; Data Source="
            + servidor + "; User id=" + usuario + "; Password=" + password + "";

        public MySqlConnection con;
        public MySqlConnection conectar()
        {
            //Instancia para conexion a SQL
            con = new MySqlConnection(cadenaConexion);
            //MySqlDataReader reader = null; //Variable para leer el resultado de la consulta

            //Agregamos try-catch para capturar posibles errores de conexion o sintaxis.
            try
            {
                MySqlCommand comando = new MySqlCommand(); //Declaración SQL para ejecutar contra una base de datos MySQL
                comando.Connection = con; //Establece la MySqlConnection utilizada por esta instancia de mySqlCommand
                con.Open(); //Abre la conexion
                MessageBox.Show("Se conecto correctamnte 666 "); //Si existe error aqui muestra el
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message); //Si existe un error aquí se muestra el mensaje
            }
            return con;
        }

        public void desconectar()
        {
            con.Close(); //Cierra la conexión a MySQL
        }
    }
}
