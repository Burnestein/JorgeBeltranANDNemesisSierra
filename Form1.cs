using System;
using System.Windows.Forms;
using JorgeBeltranANDNemesisSierra.control;
using JorgeBeltranANDNemesisSierra.vistas;
using JorgeBeltranANDNemesisSierra.entidades;
using JorgeBeltranANDNemesisSierra.recursos;

namespace JorgeBeltranANDNemesisSierra
{
    public partial class Form1 : Form
    {
        Conexion conectar = new Conexion();
        ControlUsuarios control = new ControlUsuarios();
        Usuario usuario = new Usuario();
        public static String nameuser;
        public Form1()
        {
            InitializeComponent();
            CargarImagen();
            Cursor.Current = Cursors.Default;
        }
        
        public void CargarImagen()
        {
            Pbx_Imagen.Image = Properties.Resources.nasa;
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            usuario.Usuarios = TbxUsuario.Text;
            usuario.Contra = TbxContrasena.Text;
            Cursor.Current = Cursors.Default;
            byte existe = control.ValidarUsuarios(usuario);
            if (existe == 1)
            {
                //Pasar el usuario
                nameuser = TbxUsuario.Text;
                //Mostrar el menú principal
                FrmMenu frmmenu = new FrmMenu();
                frmmenu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(Sesiones.errUsuario);
            }
        }

    }
}
