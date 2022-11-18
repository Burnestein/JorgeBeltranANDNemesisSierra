using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using JorgeBeltranANDNemesisSierra.entidades;
using System.Windows.Forms;

namespace JorgeBeltranANDNemesisSierra.control
{
    public class ControlClientes : Conexion
    {
        MySqlCommand Query = new MySqlCommand();
        MySqlDataReader consultar;
        
        public void eliminarCliente(Clientes cliente)
        {

        }public void actualizarCliente(Clientes cliente)
        {

        }public void consultarCliente(Clientes cliente)
        {

        }public void registrarCliente(Clientes cliente)
        {

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
                consultar.Read();
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
        }

        public void llenartablaClientes(DataGridView tabla)
        {
            try
            {
                Query = new MySqlCommand("Select * from tblusuarios",
                    conectar());
                Query.Prepare();

                consultar = Query.ExecuteReader();
                while (consultar.Read())
                {
                    tabla.Rows.Add(consultar["id"].ToString(),
                        consultar["usuario"].ToString(),
                        consultar["contra"].ToString());
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
