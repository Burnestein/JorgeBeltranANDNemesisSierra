using System;
using System.Drawing;
using System.Windows.Forms;

namespace JorgeBeltranANDNemesisSierra.vistas
{
    public partial class FrmMenu : Form
    {
        Button btnActive = new Button();//Obtenemos el último botón que se hizo click.
        public FrmMenu()
        {
            InitializeComponent();
        }

        void btnFocus(Button btnFocus)
        {
            btnFocus.BackColor = Color.FromArgb(75,158,253); //Cambiamos el color del botón activo
            if (btnFocus != btnActive)
            {
                btnActive.BackColor = Color.FromArgb(32,43,76);
            }
            btnActive = btnFocus;
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            btnFocus(BtnUsuarios);//Cambiar el color al ser seleccionado.
            Form userfrm = new FrmUsuarios();
            userfrm.MdiParent = this;
            PanelFormularios.Controls.Clear();
            PanelFormularios.Controls.Add(userfrm);
            userfrm.Show();
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            btnFocus(BtnProductos);//Cambiar el color al ser seleccionado.
            Form produc = new FrmProductos();
            produc.MdiParent = this;
            PanelFormularios.Controls.Clear();
            PanelFormularios.Controls.Add(produc);
            produc.Show();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {
            btnFocus(BtnClientes);//Cambiar el color al ser seleccionado.
            Form clientes = new FrmClientes();
            clientes.MdiParent = this;
            PanelFormularios.Controls.Clear();
            PanelFormularios.Controls.Add(clientes);
            clientes.Show();
        }
    }
}
