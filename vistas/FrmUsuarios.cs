using System;
using System.Windows.Forms;
using JorgeBeltranANDNemesisSierra.control;
using JorgeBeltranANDNemesisSierra.recursos;
using JorgeBeltranANDNemesisSierra.entidades;

namespace JorgeBeltranANDNemesisSierra.vistas
{
    
    public partial class FrmUsuarios : Form
    {
        ControlUsuarios control = new ControlUsuarios();
        int sel;
        public String idSel = "";
        Usuario user = new Usuario();
        public FrmUsuarios()
        {
            InitializeComponent();
            control.actualizarTabla(DgvUsuarios);
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbxID.Text = "";  
            TbxUsuario.Text = "";  
            TbxContrasena.Text = "";  
            TbxNombre.Text = "";  
            TbxApepat.Text = "";  
            TbxApemat.Text = "";  
            TbxCalle.Text = "";  
            TbxNumero.Text = "";  
            TbxColonia.Text = "";  
            TbxEstado.Text = "";  
            TbxNumCelular.Text = ""; 
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            control.actualizarTabla(DgvUsuarios);
        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel = e.RowIndex;
            idSel = DgvUsuarios.Rows[sel].Cells[0].Value.ToString();
            TbxID.Text = DgvUsuarios.Rows[sel].Cells[0].Value.ToString();
            TbxUsuario.Text = DgvUsuarios.Rows[sel].Cells[1].Value.ToString();
            TbxContrasena.Text = DgvUsuarios.Rows[sel].Cells[2].Value.ToString();
            TbxNombre.Text = DgvUsuarios.Rows[sel].Cells[3].Value.ToString();
            TbxApepat.Text = DgvUsuarios.Rows[sel].Cells[4].Value.ToString();
            TbxApemat.Text = DgvUsuarios.Rows[sel].Cells[5].Value.ToString();
            TbxCalle.Text = DgvUsuarios.Rows[sel].Cells[6].Value.ToString();
            TbxNumero.Text = DgvUsuarios.Rows[sel].Cells[7].Value.ToString();
            TbxColonia.Text = DgvUsuarios.Rows[sel].Cells[8].Value.ToString();
            TbxEstado.Text = DgvUsuarios.Rows[sel].Cells[9].Value.ToString();
            TbxNumCelular.Text = DgvUsuarios.Rows[sel].Cells[10].Value.ToString();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            if (TbxUsuario.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El usuario no puede estar vacío.";
            }
            if (TbxContrasena.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La contraseña no puede estar vacía.";
            }
            if (TbxNombre.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El nombre no puede estar vacía.";
            }
            if (TbxApepat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El Apellido paterno no puede estar vacío.";
            }
            if (TbxApemat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El Apellido materno no puede estar vacío.";
            }
            if (TbxCalle.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La calle no puede estar vacío.";
            }
            if (TbxNumero.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El número no puede estar vacío.";
            }
            if (TbxColonia.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La colonia no puede estar vacía.";
            }
            if (TbxEstado.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El estado no puede estar vacía.";
            }
            if (TbxNumCelular.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El número de celular no puede estar vacía.";
            }

            if (Sesiones.mensajeError == "")
            {
                user.Usuarios = TbxUsuario.Text;
                user.Contra = TbxContrasena.Text;
                user.Nombre = TbxNombre.Text;
                user.Apepat = TbxApepat.Text;
                user.Apemat = TbxApemat.Text;
                user.Calle = TbxCalle.Text;
                user.Numero = Convert.ToInt32(TbxNumero.Text);
                user.Colonia = TbxColonia.Text;
                user.Estado = TbxEstado.Text;
                user.Numcelular = TbxNumCelular.Text;
                control.registrarUsuario(user, DgvUsuarios);
            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (TbxUsuario.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El usuario no puede estar vacío.";
            }
            if (TbxContrasena.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La contraseña no puede estar vacía.";
            }
            if (TbxNombre.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El nombre no puede estar vacía.";
            }
            if (TbxApepat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El Apellido paterno no puede estar vacío.";
            }
            if (TbxApemat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El Apellido materno no puede estar vacío.";
            }
            if (TbxCalle.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La calle no puede estar vacío.";
            }
            if (TbxNumero.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El número no puede estar vacío.";
            }
            if (TbxColonia.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La colonia no puede estar vacía.";
            }
            if (TbxEstado.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El estado no puede estar vacía.";
            }
            if (TbxNumCelular.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El número de celular no puede estar vacía.";
            }

            if (Sesiones.mensajeError == "")
            {
                user.Usuarios = TbxUsuario.Text;
                user.Contra = TbxContrasena.Text;
                user.Nombre = TbxNombre.Text;
                user.Apepat = TbxApepat.Text;
                user.Apemat = TbxApemat.Text;
                user.Calle = TbxCalle.Text;
                user.Numero = Convert.ToInt32(TbxNumero.Text);
                user.Colonia = TbxColonia.Text;
                user.Estado = TbxEstado.Text;
                user.Numcelular = TbxNumCelular.Text;
                user.UsuarioID = Convert.ToInt32(idSel);
                control.modificarUsuario(user, DgvUsuarios);
            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (TbxUsuario.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El usuario no puede estar vacío.";
            }
            if (TbxContrasena.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La contraseña no puede estar vacía.";
            }
            if (TbxNombre.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El nombre no puede estar vacía.";
            }
            if (TbxApepat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El Apellido paterno no puede estar vacío.";
            }
            if (TbxApemat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El Apellido materno no puede estar vacío.";
            }
            if (TbxCalle.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La calle no puede estar vacío.";
            }
            if (TbxNumero.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El número no puede estar vacío.";
            }
            if (TbxColonia.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "La colonia no puede estar vacía.";
            }
            if (TbxEstado.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El estado no puede estar vacía.";
            }
            if (TbxNumCelular.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + "El número de celular no puede estar vacía.";
            }

            if (Sesiones.mensajeError == "")
            {
                user.Usuarios = TbxUsuario.Text;
                user.Contra = TbxContrasena.Text;
                user.Nombre = TbxNombre.Text;
                user.Apepat = TbxApepat.Text;
                user.Apemat = TbxApemat.Text;
                user.Calle = TbxCalle.Text;
                user.Numero = Convert.ToInt32(TbxNumero.Text);
                user.Colonia = TbxColonia.Text;
                user.Estado = TbxEstado.Text;
                user.Numcelular = TbxNumCelular.Text;
                user.UsuarioID = Convert.ToInt32(idSel);
                control.eliminarUsuario(user, DgvUsuarios);
            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteUsuarios user = new FrmReporteUsuarios();
            user.ShowDialog();
        }
    }
}
