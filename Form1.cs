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

namespace JorgeBeltranANDNemesisSierra
{
    public partial class Form1 : Form
    {
        Conexion conectar = new Conexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conectar.conectar();
        }
    }
}
