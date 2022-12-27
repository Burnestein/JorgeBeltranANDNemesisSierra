using System;
using System.Windows.Forms;
using JorgeBeltranANDNemesisSierra.control;
using JorgeBeltranANDNemesisSierra.recursos;
using JorgeBeltranANDNemesisSierra.entidades;
using JorgeBeltranANDNemesisSierra.mensajes;

namespace JorgeBeltranANDNemesisSierra.vistas
{
    public partial class FrmProveedores : Form
    {
        controlProveedores control = new controlProveedores();
        int sel;
        public String idSel = "";
        Proveedores proveedor = new Proveedores();
        public FrmProveedores()
        {
            InitializeComponent();
            control.actualizarTabla(DgvProveedores);
            DgvProveedores.Columns[8].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            DgvProveedores.AutoResizeColumns();
        }      

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbxID.Text = "";
            TbxNombre.Text = "";
            TbxApepat.Text = "";
            TbxApemat.Text = "";
            TbxDomicilio.Text = "";
            TbxEmpresa.Text = "";
            TbxColonia.Text = "";
            TbxTelefono.Text = "";
            TbxCorreo.Text = "";
        }
        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            control.actualizarTabla(DgvProveedores);
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {            
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
            if (TbxDomicilio.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.domicilio;
            }
            if (TbxEmpresa.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Empresa;
            }
            if (TbxColonia.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.colonia;
            }
            if (TbxTelefono.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.telefono;
            }
            if (TbxCorreo.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Correo;
            }

            if (Sesiones.mensajeError == "")
            {
                proveedor.Nombre = TbxNombre.Text;
                proveedor.Apepat = TbxApepat.Text;
                proveedor.Apemat = TbxApemat.Text;
                proveedor.Domicilio = TbxDomicilio.Text;
                proveedor.Empresa = TbxEmpresa.Text;
                proveedor.Colonia = TbxColonia.Text;
                proveedor.Telefono = TbxTelefono.Text;
                proveedor.Correo = TbxCorreo.Text;
                control.registrarProveedores(proveedor, DgvProveedores);
            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }
        }

        private void DgvProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            sel = e.RowIndex;
            idSel = DgvProveedores.Rows[sel].Cells[0].Value.ToString();
            TbxID.Text = DgvProveedores.Rows[sel].Cells[0].Value.ToString();
            TbxNombre.Text = DgvProveedores.Rows[sel].Cells[1].Value.ToString();
            TbxApepat.Text = DgvProveedores.Rows[sel].Cells[2].Value.ToString();
            TbxApemat.Text = DgvProveedores.Rows[sel].Cells[3].Value.ToString();
            TbxDomicilio.Text = DgvProveedores.Rows[sel].Cells[4].Value.ToString();
            TbxEmpresa.Text = DgvProveedores.Rows[sel].Cells[5].Value.ToString();
            TbxColonia.Text = DgvProveedores.Rows[sel].Cells[6].Value.ToString();
            TbxTelefono.Text = DgvProveedores.Rows[sel].Cells[7].Value.ToString();
            TbxCorreo.Text = DgvProveedores.Rows[sel].Cells[8].Value.ToString();
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
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
            if (TbxDomicilio.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.domicilio;
            }
            if (TbxEmpresa.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Empresa;
            }
            if (TbxColonia.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.colonia;
            }
            if (TbxTelefono.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.telefono;
            }
            if (TbxCorreo.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Correo;
            }

            if (Sesiones.mensajeError == "")
            {
                proveedor.Nombre = TbxNombre.Text;
                proveedor.Apepat = TbxApepat.Text;
                proveedor.Apemat = TbxApemat.Text;
                proveedor.Domicilio = TbxDomicilio.Text;
                proveedor.Empresa = TbxEmpresa.Text;
                proveedor.Colonia = TbxColonia.Text;
                proveedor.Telefono = TbxTelefono.Text;
                proveedor.Correo = TbxCorreo.Text;
                proveedor.IdProveedor = Convert.ToInt32(TbxID.Text);
                control.modificarProveedores(proveedor, DgvProveedores);
            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
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
            if (TbxDomicilio.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.domicilio;
            }
            if (TbxEmpresa.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Empresa;
            }
            if (TbxColonia.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.colonia;
            }
            if (TbxTelefono.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.telefono;
            }
            if (TbxCorreo.Text == "")
            {
                Sesiones.mensajeError = Sesiones.mensajeError + Errores.Correo;
            }

            if (Sesiones.mensajeError == "")
            {
                proveedor.Nombre = TbxNombre.Text;
                proveedor.Apepat = TbxApepat.Text;
                proveedor.Apemat = TbxApemat.Text;
                proveedor.Domicilio = TbxDomicilio.Text;
                proveedor.Empresa = TbxEmpresa.Text;
                proveedor.Colonia = TbxColonia.Text;
                proveedor.Telefono = TbxTelefono.Text;
                proveedor.Correo = TbxCorreo.Text;
                proveedor.IdProveedor = Convert.ToInt32(TbxID.Text);
                control.eliminarProveedores(proveedor, DgvProveedores);
            }
            else
            {
                MessageBox.Show(Sesiones.mensajeError);
            }
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            FrmReporteProveedores prove = new FrmReporteProveedores();
            prove.ShowDialog();
        }

        private void TbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {/*
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

        private void DgvProveedores_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
                int posicion = DgvProveedores.HitTest(e.X, e.Y).RowIndex;
                if (posicion > -1)
                {
                    menu.Items.Add("Borrar").Name = "Borrar" + posicion;
                    menu.Items.Add("Mostrar").Name = "Mostrar" + posicion;
                }
                menu.Show(DgvProveedores, e.X, e.Y);
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
                idSel = DgvProveedores.Rows[int.Parse(id2)].Cells[0].Value.ToString();
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
            String res = "ID del proveedor = " + DgvProveedores.Rows[idMostrar].Cells[0].Value.ToString() + "\n";
            res = res + "Nombre del proveedor = " + DgvProveedores.Rows[idMostrar].Cells[1].Value.ToString() + "\n";
            res = res + "Apellido Paterno del proveedor = " + DgvProveedores.Rows[idMostrar].Cells[2].Value.ToString() + "\n";
            res = res + "Apellido Materno del proveedor = " + DgvProveedores.Rows[idMostrar].Cells[3].Value.ToString() + "\n";
            res = res + "Domicilio del proveedor = " + DgvProveedores.Rows[idMostrar].Cells[4].Value.ToString() + "\n";
            res = res + "Empresa del proveedor = " + DgvProveedores.Rows[idMostrar].Cells[5].Value.ToString() + "\n";
            res = res + "Télefono del proveedor = " + DgvProveedores.Rows[idMostrar].Cells[6].Value.ToString() + "\n";
            res = res + "Correo del proveedor = " + DgvProveedores.Rows[idMostrar].Cells[7].Value.ToString() + "\n";
            MessageBox.Show(res);
        }

        private void Borrar(int idBorrar)
        {
            control.EliminarSelc(idBorrar, DgvProveedores);
        }


    }
}
