using System;
using System.Windows.Forms;
using JorgeBeltranANDNemesisSierra.control;
using JorgeBeltranANDNemesisSierra.recursos;
using JorgeBeltranANDNemesisSierra.entidades;
using JorgeBeltranANDNemesisSierra.mensajes;

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
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Usuario;
            }
            if (TbxContrasena.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Contra;
            }
            if (TbxNombre.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.nombreProduc;
            }
            if (TbxApepat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.apePat;
            }
            if (TbxApemat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.apeMat;
            }
            if (TbxCalle.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Calle;
            }
            if (TbxNumero.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Numero;
            }
            if (TbxColonia.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.colonia;
            }
            if (TbxEstado.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Estado;
            }
            if (TbxNumCelular.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.NumCelular;
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
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Usuario;
            }
            if (TbxContrasena.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Contra;
            }
            if (TbxNombre.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.nombreProduc;
            }
            if (TbxApepat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.apePat;
            }
            if (TbxApemat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.apeMat;
            }
            if (TbxCalle.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Calle;
            }
            if (TbxNumero.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Numero;
            }
            if (TbxColonia.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.colonia;
            }
            if (TbxEstado.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Estado;
            }
            if (TbxNumCelular.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.NumCelular;
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
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Usuario;
            }
            if (TbxContrasena.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Contra;
            }
            if (TbxNombre.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.nombreProduc;
            }
            if (TbxApepat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.apePat;
            }
            if (TbxApemat.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.apeMat;
            }
            if (TbxCalle.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Calle;
            }
            if (TbxNumero.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Numero;
            }
            if (TbxColonia.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.colonia;
            }
            if (TbxEstado.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Estado;
            }
            if (TbxNumCelular.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.NumCelular;
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

        private void TbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }*/
            Validar.SoloLetras(e);
        }

        private void TbxApepat_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }*/

            Validar.SoloLetras(e);
        }

        private void TbxApemat_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }*/
            Validar.SoloLetras(e);
        }


        private void TbxEstado_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }*/
            Validar.SoloLetras(e);
        }

        private void TbxColonia_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            if (e.KeyChar >= 32 && e.KeyChar <= 64 || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }*/
            Validar.SoloLetras(e);
        }
        //----------------------------------------------------------------------------------
        //Evento del mouse click derecho sobre la tabla para borrar y mostrar los datos.
        //Pendiente.
        //----------------------------------------------------------------------------------
        private void DgvUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
                int posicion = DgvUsuarios.HitTest(e.X, e.Y).RowIndex;
                if (posicion > -1)
                {
                    menu.Items.Add("Borrar").Name = "Borrar" + posicion;
                    menu.Items.Add("Mostrar").Name = "Mostrar" + posicion;
                }
                menu.Show(DgvUsuarios, e.X, e.Y);
                menu.ItemClicked += new ToolStripItemClickedEventHandler(menuclick);
            }
        }

        //----------------------------------------------------------------------------------
        //Menú desplegable
        //Pendiente.
        //----------------------------------------------------------------------------------
        private void menuclick(object sender, ToolStripItemClickedEventArgs e)
        {
            string id2 = e.ClickedItem.Name.ToString();
            string idSel = "";
            if (id2.Contains("Borrar"))
            {
                id2 = id2.Replace("Borrar", "");
                idSel = DgvUsuarios.Rows[int.Parse(id2)].Cells[0].Value.ToString();
                Borrar(int.Parse(idSel));
            }
            if (id2.Contains("Mostrar"))
            {
                id2 = id2.Replace("Mostrar", "");
                Mostrar(int.Parse(id2));
            }
        }

        private void Mostrar(int idMostrar)
        {
            String res = "ID del usuario = " + DgvUsuarios.Rows[idMostrar].Cells[0].Value.ToString() + "\n";
            res = res + "Username = " + DgvUsuarios.Rows[idMostrar].Cells[1].Value.ToString() + "\n";
            res = res + "Contraseña = " + DgvUsuarios.Rows[idMostrar].Cells[2].Value.ToString() + "\n";
            res = res + "Nombre del usuario = " + DgvUsuarios.Rows[idMostrar].Cells[3].Value.ToString() + "\n";
            res = res + "Apellido Paterno del usuario = " + DgvUsuarios.Rows[idMostrar].Cells[4].Value.ToString() + "\n";
            res = res + "Apellido Materno del usuario = " + DgvUsuarios.Rows[idMostrar].Cells[5].Value.ToString() + "\n";
            res = res + "Calle del usuario = " + DgvUsuarios.Rows[idMostrar].Cells[6].Value.ToString() + "\n";
            res = res + "Número del usuario = " + DgvUsuarios.Rows[idMostrar].Cells[7].Value.ToString() + "\n";
            res = res + "Colonia del usuario = " + DgvUsuarios.Rows[idMostrar].Cells[8].Value.ToString() + "\n";
            res = res + "Estado del usuario = " + DgvUsuarios.Rows[idMostrar].Cells[9].Value.ToString() + "\n";
            res = res + "Número de celular del usuario = " + DgvUsuarios.Rows[idMostrar].Cells[10].Value.ToString() + "\n";
            MessageBox.Show(res);
        }

        private void Borrar(int idBorrar)
        {
            control.EliminarSelc(idBorrar, DgvUsuarios);
        }

    }
}
