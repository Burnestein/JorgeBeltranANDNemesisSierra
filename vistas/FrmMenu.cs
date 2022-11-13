using System;
using System.Windows.Forms;

namespace JorgeBeltranANDNemesisSierra.vistas
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void MItemUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios user = new FrmUsuarios();
            user.ShowDialog();
        }

        private void MItemProductos_Click(object sender, EventArgs e)
        {
            FrmProductos productos = new FrmProductos();
            productos.ShowDialog();
        }
    }
}
