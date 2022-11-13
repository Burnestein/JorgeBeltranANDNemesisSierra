
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TsmiOpciones = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MItemVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.PanelBack = new System.Windows.Forms.Panel();
            this.PanelFormularios = new System.Windows.Forms.Panel();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PlFoot = new System.Windows.Forms.Panel();
            this.LblUsername = new System.Windows.Forms.Label();
            this.BtnVentas = new System.Windows.Forms.Button();
            this.BtnProveedores = new System.Windows.Forms.Button();
            this.BtnClientes = new System.Windows.Forms.Button();
            this.BtnProductos = new System.Windows.Forms.Button();
            this.BtnUsuarios = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblCompanyNombre = new System.Windows.Forms.Label();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.PanelBack.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            this.PlFoot.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiOpciones,
            this.catalogoDeProductosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(881, 24);
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
            this.MItemUsuarios.Size = new System.Drawing.Size(139, 22);
            this.MItemUsuarios.Text = "Usuarios";
            this.MItemUsuarios.Click += new System.EventHandler(this.MItemUsuarios_Click);
            // 
            // MItemProductos
            // 
            this.MItemProductos.Name = "MItemProductos";
            this.MItemProductos.Size = new System.Drawing.Size(139, 22);
            this.MItemProductos.Text = "Productos";
            this.MItemProductos.Click += new System.EventHandler(this.MItemProductos_Click);
            // 
            // MItemClientes
            // 
            this.MItemClientes.Name = "MItemClientes";
            this.MItemClientes.Size = new System.Drawing.Size(139, 22);
            this.MItemClientes.Text = "Clientes";
            // 
            // MItemProveedores
            // 
            this.MItemProveedores.Name = "MItemProveedores";
            this.MItemProveedores.Size = new System.Drawing.Size(139, 22);
            this.MItemProveedores.Text = "Proveedores";
            // 
            // MItemVentas
            // 
            this.MItemVentas.Name = "MItemVentas";
            this.MItemVentas.Size = new System.Drawing.Size(139, 22);
            this.MItemVentas.Text = "Ventas";
            // 
            // catalogoDeProductosToolStripMenuItem
            // 
            this.catalogoDeProductosToolStripMenuItem.Name = "catalogoDeProductosToolStripMenuItem";
            this.catalogoDeProductosToolStripMenuItem.Size = new System.Drawing.Size(12, 20);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // PanelBack
            // 
            this.PanelBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.PanelBack.Controls.Add(this.PanelFormularios);
            this.PanelBack.Controls.Add(this.PanelMenu);
            this.PanelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBack.Location = new System.Drawing.Point(0, 24);
            this.PanelBack.Name = "PanelBack";
            this.PanelBack.Size = new System.Drawing.Size(881, 421);
            this.PanelBack.TabIndex = 1;
            // 
            // PanelFormularios
            // 
            this.PanelFormularios.BackColor = System.Drawing.SystemColors.Control;
            this.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelFormularios.Location = new System.Drawing.Point(200, 0);
            this.PanelFormularios.Name = "PanelFormularios";
            this.PanelFormularios.Size = new System.Drawing.Size(681, 421);
            this.PanelFormularios.TabIndex = 1;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.PanelMenu.Controls.Add(this.panel2);
            this.PanelMenu.Controls.Add(this.PlFoot);
            this.PanelMenu.Controls.Add(this.BtnVentas);
            this.PanelMenu.Controls.Add(this.BtnProveedores);
            this.PanelMenu.Controls.Add(this.BtnClientes);
            this.PanelMenu.Controls.Add(this.BtnProductos);
            this.PanelMenu.Controls.Add(this.BtnUsuarios);
            this.PanelMenu.Controls.Add(this.panel1);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 421);
            this.PanelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(69)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 379);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 0;
            // 
            // PlFoot
            // 
            this.PlFoot.Controls.Add(this.LblUsername);
            this.PlFoot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PlFoot.Location = new System.Drawing.Point(0, 381);
            this.PlFoot.Name = "PlFoot";
            this.PlFoot.Size = new System.Drawing.Size(200, 40);
            this.PlFoot.TabIndex = 0;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblUsername.Location = new System.Drawing.Point(40, 12);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(120, 16);
            this.LblUsername.TabIndex = 5;
            this.LblUsername.Text = "Usuario: Example";
            // 
            // BtnVentas
            // 
            this.BtnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnVentas.FlatAppearance.BorderSize = 0;
            this.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVentas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnVentas.Image = global::JorgeBeltranANDNemesisSierra.Properties.Resources.usuarios_final;
            this.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.Location = new System.Drawing.Point(0, 236);
            this.BtnVentas.Name = "BtnVentas";
            this.BtnVentas.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnVentas.Size = new System.Drawing.Size(200, 40);
            this.BtnVentas.TabIndex = 4;
            this.BtnVentas.Text = "            Ventas";
            this.BtnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnVentas.UseVisualStyleBackColor = true;
            // 
            // BtnProveedores
            // 
            this.BtnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProveedores.FlatAppearance.BorderSize = 0;
            this.BtnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProveedores.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProveedores.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnProveedores.Image = global::JorgeBeltranANDNemesisSierra.Properties.Resources.usuarios_final;
            this.BtnProveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedores.Location = new System.Drawing.Point(0, 196);
            this.BtnProveedores.Name = "BtnProveedores";
            this.BtnProveedores.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnProveedores.Size = new System.Drawing.Size(200, 40);
            this.BtnProveedores.TabIndex = 3;
            this.BtnProveedores.Text = "            Proveedores";
            this.BtnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProveedores.UseVisualStyleBackColor = true;
            // 
            // BtnClientes
            // 
            this.BtnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnClientes.FlatAppearance.BorderSize = 0;
            this.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClientes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnClientes.Image = global::JorgeBeltranANDNemesisSierra.Properties.Resources.clientes_final;
            this.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.Location = new System.Drawing.Point(0, 156);
            this.BtnClientes.Name = "BtnClientes";
            this.BtnClientes.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnClientes.Size = new System.Drawing.Size(200, 40);
            this.BtnClientes.TabIndex = 2;
            this.BtnClientes.Text = "            Clientes";
            this.BtnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnClientes.UseVisualStyleBackColor = true;
            // 
            // BtnProductos
            // 
            this.BtnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnProductos.FlatAppearance.BorderSize = 0;
            this.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnProductos.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnProductos.Image = global::JorgeBeltranANDNemesisSierra.Properties.Resources.caja_1;
            this.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.Location = new System.Drawing.Point(0, 116);
            this.BtnProductos.Name = "BtnProductos";
            this.BtnProductos.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnProductos.Size = new System.Drawing.Size(200, 40);
            this.BtnProductos.TabIndex = 1;
            this.BtnProductos.Text = "            Productos";
            this.BtnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnProductos.UseVisualStyleBackColor = true;
            this.BtnProductos.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // BtnUsuarios
            // 
            this.BtnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(128)))), ((int)(((byte)(253)))));
            this.BtnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUsuarios.FlatAppearance.BorderSize = 0;
            this.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUsuarios.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnUsuarios.Image = global::JorgeBeltranANDNemesisSierra.Properties.Resources.usuarios_final;
            this.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuarios.Location = new System.Drawing.Point(0, 76);
            this.BtnUsuarios.Name = "BtnUsuarios";
            this.BtnUsuarios.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.BtnUsuarios.Size = new System.Drawing.Size(200, 40);
            this.BtnUsuarios.TabIndex = 0;
            this.BtnUsuarios.Text = "            Usuarios";
            this.BtnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUsuarios.UseVisualStyleBackColor = false;
            this.BtnUsuarios.Click += new System.EventHandler(this.BtnUsuarios_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblCompanyNombre);
            this.panel1.Controls.Add(this.PbxLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 76);
            this.panel1.TabIndex = 0;
            // 
            // LblCompanyNombre
            // 
            this.LblCompanyNombre.AutoSize = true;
            this.LblCompanyNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCompanyNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblCompanyNombre.Location = new System.Drawing.Point(91, 38);
            this.LblCompanyNombre.Name = "LblCompanyNombre";
            this.LblCompanyNombre.Size = new System.Drawing.Size(63, 19);
            this.LblCompanyNombre.TabIndex = 1;
            this.LblCompanyNombre.Text = "Jonem";
            // 
            // PbxLogo
            // 
            this.PbxLogo.Image = global::JorgeBeltranANDNemesisSierra.Properties.Resources.logo_nasa;
            this.PbxLogo.Location = new System.Drawing.Point(1, 3);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(121, 70);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbxLogo.TabIndex = 0;
            this.PbxLogo.TabStop = false;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 445);
            this.Controls.Add(this.PanelBack);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelBack.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            this.PlFoot.ResumeLayout(false);
            this.PlFoot.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TsmiOpciones;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MItemProductos;
        private System.Windows.Forms.ToolStripMenuItem MItemClientes;
        private System.Windows.Forms.ToolStripMenuItem MItemVentas;
        private System.Windows.Forms.ToolStripMenuItem MItemProveedores;
        private System.Windows.Forms.ToolStripMenuItem catalogoDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MItemUsuarios;
        private System.Windows.Forms.Panel PanelBack;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel PanelFormularios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblCompanyNombre;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.Button BtnUsuarios;
        private System.Windows.Forms.Button BtnVentas;
        private System.Windows.Forms.Button BtnProveedores;
        private System.Windows.Forms.Button BtnClientes;
        private System.Windows.Forms.Button BtnProductos;
        private System.Windows.Forms.Panel PlFoot;
        private System.Windows.Forms.Label LblUsername;
        private System.Windows.Forms.Panel panel2;
    }
}