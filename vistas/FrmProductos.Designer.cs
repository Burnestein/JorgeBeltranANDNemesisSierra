
namespace JorgeBeltranANDNemesisSierra.vistas
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.LblNombreProd = new System.Windows.Forms.Label();
            this.TbxNombreProd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxPrecioCompra = new System.Windows.Forms.TextBox();
            this.TbxPrecioVenta = new System.Windows.Forms.TextBox();
            this.TbxCodigo = new System.Windows.Forms.TextBox();
            this.TbxDescripcion = new System.Windows.Forms.TextBox();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.LblHeader = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.TbxID = new System.Windows.Forms.TextBox();
            this.DgvProductos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNombreProd
            // 
            this.LblNombreProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNombreProd.AutoSize = true;
            this.LblNombreProd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblNombreProd.Location = new System.Drawing.Point(182, 87);
            this.LblNombreProd.Name = "LblNombreProd";
            this.LblNombreProd.Size = new System.Drawing.Size(154, 17);
            this.LblNombreProd.TabIndex = 0;
            this.LblNombreProd.Text = "Nombre del producto:";
            // 
            // TbxNombreProd
            // 
            this.TbxNombreProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxNombreProd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxNombreProd.Location = new System.Drawing.Point(361, 87);
            this.TbxNombreProd.Name = "TbxNombreProd";
            this.TbxNombreProd.Size = new System.Drawing.Size(204, 23);
            this.TbxNombreProd.TabIndex = 1;
            this.TbxNombreProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxNombreProd_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label1.Location = new System.Drawing.Point(182, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Precio para Compra:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label2.Location = new System.Drawing.Point(182, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Precio para Venta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(182, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(182, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripción:";
            // 
            // TbxPrecioCompra
            // 
            this.TbxPrecioCompra.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxPrecioCompra.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxPrecioCompra.Location = new System.Drawing.Point(361, 128);
            this.TbxPrecioCompra.Name = "TbxPrecioCompra";
            this.TbxPrecioCompra.Size = new System.Drawing.Size(204, 23);
            this.TbxPrecioCompra.TabIndex = 6;
            // 
            // TbxPrecioVenta
            // 
            this.TbxPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxPrecioVenta.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxPrecioVenta.Location = new System.Drawing.Point(361, 163);
            this.TbxPrecioVenta.Name = "TbxPrecioVenta";
            this.TbxPrecioVenta.Size = new System.Drawing.Size(204, 23);
            this.TbxPrecioVenta.TabIndex = 7;
            // 
            // TbxCodigo
            // 
            this.TbxCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxCodigo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxCodigo.Location = new System.Drawing.Point(361, 200);
            this.TbxCodigo.Name = "TbxCodigo";
            this.TbxCodigo.Size = new System.Drawing.Size(204, 23);
            this.TbxCodigo.TabIndex = 8;
            this.TbxCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxCodigo_KeyPress);
            // 
            // TbxDescripcion
            // 
            this.TbxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxDescripcion.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxDescripcion.Location = new System.Drawing.Point(361, 234);
            this.TbxDescripcion.Name = "TbxDescripcion";
            this.TbxDescripcion.Size = new System.Drawing.Size(204, 23);
            this.TbxDescripcion.TabIndex = 9;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnActualizar.Location = new System.Drawing.Point(220, 276);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(94, 34);
            this.BtnActualizar.TabIndex = 10;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnInsertar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnInsertar.Location = new System.Drawing.Point(341, 276);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(94, 34);
            this.BtnInsertar.TabIndex = 11;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnModificar.Location = new System.Drawing.Point(460, 276);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(94, 34);
            this.BtnModificar.TabIndex = 12;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnEliminar.Location = new System.Drawing.Point(588, 276);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(94, 34);
            this.BtnEliminar.TabIndex = 13;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // LblHeader
            // 
            this.LblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.Location = new System.Drawing.Point(313, 9);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(229, 25);
            this.LblHeader.TabIndex = 14;
            this.LblHeader.Text = "Detalles del producto";
            // 
            // LblID
            // 
            this.LblID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(182, 52);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(25, 17);
            this.LblID.TabIndex = 15;
            this.LblID.Text = "ID:";
            // 
            // TbxID
            // 
            this.TbxID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxID.Enabled = false;
            this.TbxID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxID.Location = new System.Drawing.Point(361, 54);
            this.TbxID.Name = "TbxID";
            this.TbxID.Size = new System.Drawing.Size(204, 23);
            this.TbxID.TabIndex = 16;
            // 
            // DgvProductos
            // 
            this.DgvProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.PrecioCompra,
            this.PrecioVenta,
            this.Codigo,
            this.Descripcion});
            this.DgvProductos.Location = new System.Drawing.Point(29, 322);
            this.DgvProductos.Name = "DgvProductos";
            this.DgvProductos.Size = new System.Drawing.Size(825, 150);
            this.DgvProductos.TabIndex = 17;
            this.DgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProductos_CellClick);
            this.DgvProductos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvProductos_MouseClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID del producto";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre del Producto";
            this.Nombre.Name = "Nombre";
            // 
            // PrecioCompra
            // 
            this.PrecioCompra.HeaderText = "Precio de Compra";
            this.PrecioCompra.Name = "PrecioCompra";
            // 
            // PrecioVenta
            // 
            this.PrecioVenta.HeaderText = "Precio de Venta";
            this.PrecioVenta.Name = "PrecioVenta";
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código del Producto";
            this.Codigo.Name = "Codigo";
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripción del producto";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Width = 300;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnLimpiar.Location = new System.Drawing.Point(597, 139);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(94, 34);
            this.BtnLimpiar.TabIndex = 18;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnReporte
            // 
            this.BtnReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReporte.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnReporte.Location = new System.Drawing.Point(704, 276);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(94, 34);
            this.BtnReporte.TabIndex = 19;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 517);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.DgvProductos);
            this.Controls.Add(this.TbxID);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.TbxDescripcion);
            this.Controls.Add(this.TbxCodigo);
            this.Controls.Add(this.TbxPrecioVenta);
            this.Controls.Add(this.TbxPrecioCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxNombreProd);
            this.Controls.Add(this.LblNombreProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProductos";
            this.Text = "Catálogo de productos";
            ((System.ComponentModel.ISupportInitialize)(this.DgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombreProd;
        private System.Windows.Forms.TextBox TbxNombreProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxPrecioCompra;
        private System.Windows.Forms.TextBox TbxPrecioVenta;
        private System.Windows.Forms.TextBox TbxCodigo;
        private System.Windows.Forms.TextBox TbxDescripcion;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.TextBox TbxID;
        private System.Windows.Forms.DataGridView DgvProductos;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.Button BtnReporte;
    }
}