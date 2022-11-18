using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JorgeBeltranANDNemesisSierra.control;

namespace JorgeBeltranANDNemesisSierra.vistas
{
    public partial class FrmClientes : Form
    { 
        ControlClientes clientes = new ControlClientes();
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TbxNombre.Text = "";
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            clientes.llenaCombo(Cbxusuarios);
            clientes.llenartablaClientes(DgvClientes);
        }



    }
}
