using System;
using System.Windows.Forms;
using JorgeBeltranANDNemesisSierra.control;
using JorgeBeltranANDNemesisSierra.vistas;
using JorgeBeltranANDNemesisSierra.entidades;

namespace JorgeBeltranANDNemesisSierra
{
    public partial class Form1 : Form
    {
        Conexion conectar = new Conexion();
        ControlUsuarios control = new ControlUsuarios();
        Usuario usuario = new Usuario();
        public Form1()
        {
            InitializeComponent();
        }

        public void CargarImagen()
        {
            Pbx_Imagen.Image = global::JorgeBeltranANDNemesisSierra.recursos.nasa;
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            usuario.Usuarios = TbxUsuario.Text;
            usuario.Contra = TbxContrasena.Text;
            byte existe = control.ValidarUsuarios(usuario);             
            if (existe == 1)
            {
                //Mostrar el menú principal
                FrmMenu frmmenu = new FrmMenu();
                frmmenu.Show();
                this.Hide();
                
            }
             
            else
            {
                MessageBox.Show("Usuario no válido");
            }            
        }
    }
}
