
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
            this.TbxUsuario = new System.Windows.Forms.TextBox();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.TbxFechaVenta = new System.Windows.Forms.TextBox();
            this.LblFechaVenta = new System.Windows.Forms.Label();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TbxID = new System.Windows.Forms.TextBox();
            this.LblID = new System.Windows.Forms.Label();
            this.LblHeader = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.TbxProducto = new System.Windows.Forms.TextBox();
            this.TbxNomCliente = new System.Windows.Forms.TextBox();
            this.TbxTotal = new System.Windows.Forms.TextBox();
            this.TbxPrecio = new System.Windows.Forms.TextBox();
            this.LblProducto = new System.Windows.Forms.Label();
            this.LblNomCliente = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.TbxCantidad = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.DgvVentas = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apepat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apemat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitecredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxUsuario
            // 
            this.TbxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxUsuario.Location = new System.Drawing.Point(421, 82);
            this.TbxUsuario.Name = "TbxUsuario";
            this.TbxUsuario.Size = new System.Drawing.Size(140, 23);
            this.TbxUsuario.TabIndex = 66;
            // 
            // LblUsuario
            // 
            this.LblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(462, 52);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(58, 17);
            this.LblUsuario.TabIndex = 65;
            this.LblUsuario.Text = "Usuario:";
            // 
            // TbxFechaVenta
            // 
            this.TbxFechaVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxFechaVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxFechaVenta.Location = new System.Drawing.Point(192, 216);
            this.TbxFechaVenta.Name = "TbxFechaVenta";
            this.TbxFechaVenta.Size = new System.Drawing.Size(204, 23);
            this.TbxFechaVenta.TabIndex = 64;
            // 
            // LblFechaVenta
            // 
            this.LblFechaVenta.AutoSize = true;
            this.LblFechaVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblFechaVenta.Location = new System.Drawing.Point(13, 222);
            this.LblFechaVenta.Name = "LblFechaVenta";
            this.LblFechaVenta.Size = new System.Drawing.Size(130, 17);
            this.LblFechaVenta.TabIndex = 63;
            this.LblFechaVenta.Text = "Fecha de la venta:";
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnLimpiar.Location = new System.Drawing.Point(143, 287);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(94, 34);
            this.BtnLimpiar.TabIndex = 60;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TbxID
            // 
            this.TbxID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxID.Enabled = false;
            this.TbxID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxID.Location = new System.Drawing.Point(192, 49);
            this.TbxID.Name = "TbxID";
            this.TbxID.Size = new System.Drawing.Size(204, 23);
            this.TbxID.TabIndex = 59;
            // 
            // LblID
            // 
            this.LblID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(13, 47);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(25, 17);
            this.LblID.TabIndex = 58;
            this.LblID.Text = "ID:";
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
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnEliminar.Location = new System.Drawing.Point(630, 287);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(94, 34);
            this.BtnEliminar.TabIndex = 56;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnModificar.Location = new System.Drawing.Point(511, 287);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(94, 34);
            this.BtnModificar.TabIndex = 55;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnInsertar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnInsertar.Location = new System.Drawing.Point(384, 287);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(94, 34);
            this.BtnInsertar.TabIndex = 54;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnActualizar.Location = new System.Drawing.Point(263, 287);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(94, 34);
            this.BtnActualizar.TabIndex = 53;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TbxProducto
            // 
            this.TbxProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxProducto.Location = new System.Drawing.Point(192, 187);
            this.TbxProducto.Name = "TbxProducto";
            this.TbxProducto.Size = new System.Drawing.Size(204, 23);
            this.TbxProducto.TabIndex = 52;
            // 
            // TbxNomCliente
            // 
            this.TbxNomCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxNomCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxNomCliente.Location = new System.Drawing.Point(192, 244);
            this.TbxNomCliente.Name = "TbxNomCliente";
            this.TbxNomCliente.Size = new System.Drawing.Size(204, 23);
            this.TbxNomCliente.TabIndex = 51;
            // 
            // TbxTotal
            // 
            this.TbxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxTotal.Location = new System.Drawing.Point(192, 158);
            this.TbxTotal.Name = "TbxTotal";
            this.TbxTotal.Size = new System.Drawing.Size(204, 23);
            this.TbxTotal.TabIndex = 50;
            // 
            // TbxPrecio
            // 
            this.TbxPrecio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxPrecio.Location = new System.Drawing.Point(192, 123);
            this.TbxPrecio.Name = "TbxPrecio";
            this.TbxPrecio.Size = new System.Drawing.Size(204, 23);
            this.TbxPrecio.TabIndex = 49;
            // 
            // LblProducto
            // 
            this.LblProducto.AutoSize = true;
            this.LblProducto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblProducto.Location = new System.Drawing.Point(13, 187);
            this.LblProducto.Name = "LblProducto";
            this.LblProducto.Size = new System.Drawing.Size(72, 17);
            this.LblProducto.TabIndex = 48;
            this.LblProducto.Text = "Producto:";
            // 
            // LblNomCliente
            // 
            this.LblNomCliente.AutoSize = true;
            this.LblNomCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblNomCliente.Location = new System.Drawing.Point(13, 250);
            this.LblNomCliente.Name = "LblNomCliente";
            this.LblNomCliente.Size = new System.Drawing.Size(136, 17);
            this.LblNomCliente.TabIndex = 47;
            this.LblNomCliente.Text = "Nombre del cliente:";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblTotal.Location = new System.Drawing.Point(13, 158);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(43, 17);
            this.LblTotal.TabIndex = 46;
            this.LblTotal.Text = "Total:";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblPrecio.Location = new System.Drawing.Point(13, 121);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(52, 17);
            this.LblPrecio.TabIndex = 45;
            this.LblPrecio.Text = "Precio:";
            // 
            // TbxCantidad
            // 
            this.TbxCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxCantidad.Location = new System.Drawing.Point(192, 82);
            this.TbxCantidad.Name = "TbxCantidad";
            this.TbxCantidad.Size = new System.Drawing.Size(204, 23);
            this.TbxCantidad.TabIndex = 44;
            // 
            // LblCantidad
            // 
            this.LblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblCantidad.Location = new System.Drawing.Point(13, 82);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(75, 17);
            this.LblCantidad.TabIndex = 43;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // DgvVentas
            // 
            this.DgvVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.apepat,
            this.apemat,
            this.domicilio,
            this.colonia,
            this.telefono,
            this.nombre,
            this.limitecredito});
            this.DgvVentas.Location = new System.Drawing.Point(4, 330);
            this.DgvVentas.Name = "DgvVentas";
            this.DgvVentas.Size = new System.Drawing.Size(841, 150);
            this.DgvVentas.TabIndex = 62;
            this.DgvVentas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVentas_CellClick);
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "ID ";
            this.id_usuario.Name = "id_usuario";
            // 
            // apepat
            // 
            this.apepat.HeaderText = "Cantidad:";
            this.apepat.Name = "apepat";
            // 
            // apemat
            // 
            this.apemat.HeaderText = "Precio:";
            this.apemat.Name = "apemat";
            // 
            // domicilio
            // 
            this.domicilio.HeaderText = "Total";
            this.domicilio.Name = "domicilio";
            // 
            // colonia
            // 
            this.colonia.HeaderText = "Producto";
            this.colonia.Name = "colonia";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Fecha de la venta";
            this.telefono.Name = "telefono";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre del cliente:";
            this.nombre.Name = "nombre";
            // 
            // limitecredito
            // 
            this.limitecredito.HeaderText = "Usuario";
            this.limitecredito.Name = "limitecredito";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JorgeBeltranANDNemesisSierra.Properties.Resources.nasa;
            this.pictureBox1.Location = new System.Drawing.Point(591, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnCalcular.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnCalcular.Location = new System.Drawing.Point(440, 123);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(94, 34);
            this.BtnCalcular.TabIndex = 67;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // FrmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 478);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TbxUsuario);
            this.Controls.Add(this.LblUsuario);
            this.Controls.Add(this.TbxFechaVenta);
            this.Controls.Add(this.LblFechaVenta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TbxID);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.TbxProducto);
            this.Controls.Add(this.TbxNomCliente);
            this.Controls.Add(this.TbxTotal);
            this.Controls.Add(this.TbxPrecio);
            this.Controls.Add(this.LblProducto);
            this.Controls.Add(this.LblNomCliente);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.TbxCantidad);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.DgvVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVentas";
            this.Text = "FrmVentas";
            ((System.ComponentModel.ISupportInitialize)(this.DgvVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxUsuario;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.TextBox TbxFechaVenta;
        private System.Windows.Forms.Label LblFechaVenta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TextBox TbxID;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox TbxProducto;
        private System.Windows.Forms.TextBox TbxNomCliente;
        private System.Windows.Forms.TextBox TbxTotal;
        private System.Windows.Forms.TextBox TbxPrecio;
        private System.Windows.Forms.Label LblProducto;
        private System.Windows.Forms.Label LblNomCliente;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.TextBox TbxCantidad;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.DataGridView DgvVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn apepat;
        private System.Windows.Forms.DataGridViewTextBoxColumn apemat;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitecredito;
        private System.Windows.Forms.Button BtnCalcular;
    }
}