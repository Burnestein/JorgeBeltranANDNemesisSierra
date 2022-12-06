
namespace JorgeBeltranANDNemesisSierra.vistas
{
    partial class FrmVentas
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
            this.TbxFechaVenta = new System.Windows.Forms.TextBox();
            this.LblFechaVenta = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.LblHeader = new System.Windows.Forms.Label();
            this.TbxNomCliente = new System.Windows.Forms.TextBox();
            this.TbxTotal = new System.Windows.Forms.TextBox();
            this.LblNomCliente = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TbxCantidad = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.DgvVentas = new System.Windows.Forms.DataGridView();
            this.colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apepat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apemat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbxProductos = new System.Windows.Forms.ComboBox();
            this.BtnSeleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxUsername = new System.Windows.Forms.TextBox();
            this.LblUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxFechaVenta
            // 
            this.TbxFechaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxFechaVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxFechaVenta.Location = new System.Drawing.Point(559, 68);
            this.TbxFechaVenta.Name = "TbxFechaVenta";
            this.TbxFechaVenta.Size = new System.Drawing.Size(204, 23);
            this.TbxFechaVenta.TabIndex = 64;
            // 
            // LblFechaVenta
            // 
            this.LblFechaVenta.AutoSize = true;
            this.LblFechaVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblFechaVenta.Location = new System.Drawing.Point(423, 74);
            this.LblFechaVenta.Name = "LblFechaVenta";
            this.LblFechaVenta.Size = new System.Drawing.Size(130, 17);
            this.LblFechaVenta.TabIndex = 63;
            this.LblFechaVenta.Text = "Fecha de la venta:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnLimpiar.Location = new System.Drawing.Point(246, 182);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(94, 34);
            this.BtnLimpiar.TabIndex = 60;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // LblHeader
            // 
            this.LblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.Location = new System.Drawing.Point(345, 9);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(175, 25);
            this.LblHeader.TabIndex = 57;
            this.LblHeader.Text = "Datos de ventas";
            // 
            // TbxNomCliente
            // 
            this.TbxNomCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxNomCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxNomCliente.Location = new System.Drawing.Point(192, 71);
            this.TbxNomCliente.Name = "TbxNomCliente";
            this.TbxNomCliente.Size = new System.Drawing.Size(204, 23);
            this.TbxNomCliente.TabIndex = 51;
            // 
            // TbxTotal
            // 
            this.TbxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxTotal.Enabled = false;
            this.TbxTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxTotal.Location = new System.Drawing.Point(535, 438);
            this.TbxTotal.Name = "TbxTotal";
            this.TbxTotal.Size = new System.Drawing.Size(204, 23);
            this.TbxTotal.TabIndex = 50;
            // 
            // LblNomCliente
            // 
            this.LblNomCliente.AutoSize = true;
            this.LblNomCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblNomCliente.Location = new System.Drawing.Point(13, 71);
            this.LblNomCliente.Name = "LblNomCliente";
            this.LblNomCliente.Size = new System.Drawing.Size(136, 17);
            this.LblNomCliente.TabIndex = 47;
            this.LblNomCliente.Text = "Nombre del cliente:";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblTotal.Location = new System.Drawing.Point(399, 441);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(43, 17);
            this.LblTotal.TabIndex = 46;
            this.LblTotal.Text = "Total:";
            // 
            // TbxCantidad
            // 
            this.TbxCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxCantidad.Location = new System.Drawing.Point(613, 195);
            this.TbxCantidad.Name = "TbxCantidad";
            this.TbxCantidad.Size = new System.Drawing.Size(70, 23);
            this.TbxCantidad.TabIndex = 44;
            // 
            // LblCantidad
            // 
            this.LblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblCantidad.Location = new System.Drawing.Point(610, 164);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(75, 17);
            this.LblCantidad.TabIndex = 43;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // DgvVentas
            // 
            this.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colonia,
            this.apepat,
            this.precio,
            this.apemat,
            this.iva,
            this.domicilio});
            this.DgvVentas.Location = new System.Drawing.Point(92, 276);
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.Size = new System.Drawing.Size(646, 150);
            this.DgvVentas.TabIndex = 62;
            this.DgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVentas_CellClick);
            // 
            // colonia
            // 
            this.colonia.HeaderText = "Producto";
            this.colonia.Name = "colonia";
            // 
            // apepat
            // 
            this.apepat.HeaderText = "Cantidad:";
            this.apepat.Name = "apepat";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // apemat
            // 
            this.apemat.HeaderText = "Subtotal:";
            this.apemat.Name = "apemat";
            // 
            // iva
            // 
            this.iva.HeaderText = "IVA";
            this.iva.Name = "iva";
            // 
            // domicilio
            // 
            this.domicilio.HeaderText = "Total";
            this.domicilio.Name = "domicilio";
            // 
            // CbxProductos
            // 
            this.CbxProductos.FormattingEnabled = true;
            this.CbxProductos.Location = new System.Drawing.Point(440, 195);
            this.CbxProductos.Name = "CbxProductos";
            this.CbxProductos.Size = new System.Drawing.Size(121, 21);
            this.CbxProductos.TabIndex = 66;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSeleccionar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnSeleccionar.Location = new System.Drawing.Point(717, 184);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(94, 34);
            this.BtnSeleccionar.TabIndex = 67;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.UseVisualStyleBackColor = true;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(437, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 17);
            this.label1.TabIndex = 68;
            this.label1.Text = "Selecciona un producto:";
            // 
            // TbxUsername
            // 
            this.TbxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxUsername.Location = new System.Drawing.Point(192, 100);
            this.TbxUsername.Name = "TbxUsername";
            this.TbxUsername.Size = new System.Drawing.Size(204, 23);
            this.TbxUsername.TabIndex = 70;
            // 
            // LblUsername
            // 
            this.LblUsername.AutoSize = true;
            this.LblUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblUsername.Location = new System.Drawing.Point(12, 100);
            this.LblUsername.Name = "LblUsername";
            this.LblUsername.Size = new System.Drawing.Size(75, 17);
            this.LblUsername.TabIndex = 69;
            this.LblUsername.Text = "Username:";
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 478);
            this.Controls.Add(this.TbxUsername);
            this.Controls.Add(this.LblUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.CbxProductos);
            this.Controls.Add(this.TbxFechaVenta);
            this.Controls.Add(this.LblFechaVenta);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.TbxNomCliente);
            this.Controls.Add(this.TbxTotal);
            this.Controls.Add(this.LblNomCliente);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.TbxCantidad);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.DgvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbxFechaVenta;
        private System.Windows.Forms.Label LblFechaVenta;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.TextBox TbxNomCliente;
        private System.Windows.Forms.TextBox TbxTotal;
        private System.Windows.Forms.Label LblNomCliente;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox TbxCantidad;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.ComboBox CbxProductos;
        private System.Windows.Forms.Button BtnSeleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn apepat;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn apemat;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxUsername;
        private System.Windows.Forms.Label LblUsername;
    }
}