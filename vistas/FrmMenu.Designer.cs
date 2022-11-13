
namespace JorgeBeltranANDNemesisSierra.vistas
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsmiOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiOpciones});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TsmiOpciones
            // 
            this.TsmiOpciones.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MItemUsuarios,
            this.MItemProductos,
            this.MItemClientes,
            this.MItemProveedores,
            this.MItemVentas});
            this.TsmiOpciones.Name = "TsmiOpciones";
            this.TsmiOpciones.Size = new System.Drawing.Size(69, 20);
            this.TsmiOpciones.Text = "Opciones";
            this.TsmiOpciones.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // MItemUsuarios
            // 
            this.MItemUsuarios.Name = "MItemUsuarios";
            this.MItemUsuarios.Size = new System.Drawing.Size(180, 22);
            this.MItemUsuarios.Text = "Usuarios";
            this.MItemUsuarios.Click += new System.EventHandler(this.MItemUsuarios_Click);
            // 
            // MItemProductos
            // 
            this.MItemProductos.Name = "MItemProductos";
            this.MItemProductos.Size = new System.Drawing.Size(180, 22);
            this.MItemProductos.Text = "Productos";
            this.MItemProductos.Click += new System.EventHandler(this.MItemProductos_Click);
            // 
            // MItemClientes
            // 
            this.MItemClientes.Name = "MItemClientes";
            this.MItemClientes.Size = new System.Drawing.Size(180, 22);
            this.MItemClientes.Text = "Clientes";
            // 
            // MItemProveedores
            // 
            this.MItemProveedores.Name = "MItemProveedores";
            this.MItemProveedores.Size = new System.Drawing.Size(180, 22);
            this.MItemProveedores.Text = "Proveedores";
            // 
            // MItemVentas
            // 
            this.MItemVentas.Name = "MItemVentas";
            this.MItemVentas.Size = new System.Drawing.Size(180, 22);
            this.MItemVentas.Text = "Ventas";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsmiOpciones;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MItemUsuarios;
        private System.Windows.Forms.ToolStripMenuItem MItemProductos;
        private System.Windows.Forms.ToolStripMenuItem MItemClientes;
        private System.Windows.Forms.ToolStripMenuItem MItemVentas;
        private System.Windows.Forms.ToolStripMenuItem MItemProveedores;
    }
}