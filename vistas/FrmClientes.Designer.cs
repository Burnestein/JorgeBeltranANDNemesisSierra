
namespace JorgeBeltranANDNemesisSierra.vistas
{
    partial class FrmClientes
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
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TbxID = new System.Windows.Forms.TextBox();
            this.LblID = new System.Windows.Forms.Label();
            this.LblHeader = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.TbxDomicilio = new System.Windows.Forms.TextBox();
            this.TbxTelefono = new System.Windows.Forms.TextBox();
            this.TbxApemat = new System.Windows.Forms.TextBox();
            this.TbxApepat = new System.Windows.Forms.TextBox();
            this.LblCalle = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblApeMat = new System.Windows.Forms.Label();
            this.LblApePat = new System.Windows.Forms.Label();
            this.TbxNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DgvClientes = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apepat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apemat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitecredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbxColonia = new System.Windows.Forms.TextBox();
            this.LblColonia = new System.Windows.Forms.Label();
            this.TbxLimiteCredito = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnLimpiar.Location = new System.Drawing.Point(110, 284);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(94, 34);
            this.BtnLimpiar.TabIndex = 36;
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
            this.TbxID.Location = new System.Drawing.Point(193, 49);
            this.TbxID.Name = "TbxID";
            this.TbxID.Size = new System.Drawing.Size(204, 23);
            this.TbxID.TabIndex = 35;
            // 
            // LblID
            // 
            this.LblID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(14, 47);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(25, 17);
            this.LblID.TabIndex = 34;
            this.LblID.Text = "ID:";
            // 
            // LblHeader
            // 
            this.LblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.Location = new System.Drawing.Point(346, 9);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(181, 25);
            this.LblHeader.TabIndex = 33;
            this.LblHeader.Text = "Datos del cliente";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnEliminar.Location = new System.Drawing.Point(583, 284);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(94, 34);
            this.BtnEliminar.TabIndex = 32;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnModificar.Location = new System.Drawing.Point(463, 284);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(94, 34);
            this.BtnModificar.TabIndex = 31;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnInsertar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnInsertar.Location = new System.Drawing.Point(351, 284);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(94, 34);
            this.BtnInsertar.TabIndex = 30;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnActualizar.Location = new System.Drawing.Point(230, 284);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(94, 34);
            this.BtnActualizar.TabIndex = 29;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TbxDomicilio
            // 
            this.TbxDomicilio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxDomicilio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxDomicilio.Location = new System.Drawing.Point(193, 187);
            this.TbxDomicilio.Name = "TbxDomicilio";
            this.TbxDomicilio.Size = new System.Drawing.Size(204, 23);
            this.TbxDomicilio.TabIndex = 28;
            // 
            // TbxTelefono
            // 
            this.TbxTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxTelefono.Location = new System.Drawing.Point(193, 244);
            this.TbxTelefono.Name = "TbxTelefono";
            this.TbxTelefono.Size = new System.Drawing.Size(204, 23);
            this.TbxTelefono.TabIndex = 27;
            // 
            // TbxApemat
            // 
            this.TbxApemat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxApemat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxApemat.Location = new System.Drawing.Point(193, 158);
            this.TbxApemat.Name = "TbxApemat";
            this.TbxApemat.Size = new System.Drawing.Size(204, 23);
            this.TbxApemat.TabIndex = 26;
            // 
            // TbxApepat
            // 
            this.TbxApepat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxApepat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxApepat.Location = new System.Drawing.Point(193, 123);
            this.TbxApepat.Name = "TbxApepat";
            this.TbxApepat.Size = new System.Drawing.Size(204, 23);
            this.TbxApepat.TabIndex = 25;
            // 
            // LblCalle
            // 
            this.LblCalle.AutoSize = true;
            this.LblCalle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblCalle.Location = new System.Drawing.Point(14, 187);
            this.LblCalle.Name = "LblCalle";
            this.LblCalle.Size = new System.Drawing.Size(73, 17);
            this.LblCalle.TabIndex = 24;
            this.LblCalle.Text = "Domicilio:";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblTelefono.Location = new System.Drawing.Point(14, 250);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(66, 17);
            this.LblTelefono.TabIndex = 23;
            this.LblTelefono.Text = "Teléfono:";
            // 
            // LblApeMat
            // 
            this.LblApeMat.AutoSize = true;
            this.LblApeMat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblApeMat.Location = new System.Drawing.Point(14, 158);
            this.LblApeMat.Name = "LblApeMat";
            this.LblApeMat.Size = new System.Drawing.Size(125, 17);
            this.LblApeMat.TabIndex = 22;
            this.LblApeMat.Text = "Apellido materno:";
            // 
            // LblApePat
            // 
            this.LblApePat.AutoSize = true;
            this.LblApePat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblApePat.Location = new System.Drawing.Point(14, 121);
            this.LblApePat.Name = "LblApePat";
            this.LblApePat.Size = new System.Drawing.Size(121, 17);
            this.LblApePat.TabIndex = 21;
            this.LblApePat.Text = "Apellido paterno:";
            // 
            // TbxNombre
            // 
            this.TbxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxNombre.Location = new System.Drawing.Point(193, 82);
            this.TbxNombre.Name = "TbxNombre";
            this.TbxNombre.Size = new System.Drawing.Size(204, 23);
            this.TbxNombre.TabIndex = 20;
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblNombre.Location = new System.Drawing.Point(14, 82);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(65, 17);
            this.LblNombre.TabIndex = 19;
            this.LblNombre.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JorgeBeltranANDNemesisSierra.Properties.Resources.nasa;
            this.pictureBox1.Location = new System.Drawing.Point(592, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // DgvClientes
            // 
            this.DgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.nombre,
            this.apepat,
            this.apemat,
            this.domicilio,
            this.colonia,
            this.telefono,
            this.limitecredito});
            this.DgvClientes.Location = new System.Drawing.Point(12, 341);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.Size = new System.Drawing.Size(841, 150);
            this.DgvClientes.TabIndex = 38;
            this.DgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvClientes_CellClick);
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "ID Del Cliente";
            this.id_cliente.Name = "id_cliente";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre del cliente:";
            this.nombre.Name = "nombre";
            // 
            // apepat
            // 
            this.apepat.HeaderText = "Apellido paterno del cliente";
            this.apepat.Name = "apepat";
            // 
            // apemat
            // 
            this.apemat.HeaderText = "Apellido materno del cliente";
            this.apemat.Name = "apemat";
            // 
            // domicilio
            // 
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.Name = "domicilio";
            // 
            // colonia
            // 
            this.colonia.HeaderText = "Colonia";
            this.colonia.Name = "colonia";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            // 
            // limitecredito
            // 
            this.limitecredito.HeaderText = "Limite Credito";
            this.limitecredito.Name = "limitecredito";
            // 
            // TbxColonia
            // 
            this.TbxColonia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxColonia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxColonia.Location = new System.Drawing.Point(193, 216);
            this.TbxColonia.Name = "TbxColonia";
            this.TbxColonia.Size = new System.Drawing.Size(204, 23);
            this.TbxColonia.TabIndex = 40;
            // 
            // LblColonia
            // 
            this.LblColonia.AutoSize = true;
            this.LblColonia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblColonia.Location = new System.Drawing.Point(14, 222);
            this.LblColonia.Name = "LblColonia";
            this.LblColonia.Size = new System.Drawing.Size(64, 17);
            this.LblColonia.TabIndex = 39;
            this.LblColonia.Text = "Colonia:";
            // 
            // TbxLimiteCredito
            // 
            this.TbxLimiteCredito.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxLimiteCredito.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxLimiteCredito.Location = new System.Drawing.Point(422, 82);
            this.TbxLimiteCredito.Name = "TbxLimiteCredito";
            this.TbxLimiteCredito.Size = new System.Drawing.Size(140, 23);
            this.TbxLimiteCredito.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(441, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Limite crédito:";
            // 
            // BtnReporte
            // 
            this.BtnReporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnReporte.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnReporte.Location = new System.Drawing.Point(703, 284);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(94, 34);
            this.BtnReporte.TabIndex = 95;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 517);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.TbxLimiteCredito);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxColonia);
            this.Controls.Add(this.LblColonia);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TbxID);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.TbxDomicilio);
            this.Controls.Add(this.TbxTelefono);
            this.Controls.Add(this.TbxApemat);
            this.Controls.Add(this.TbxApepat);
            this.Controls.Add(this.LblCalle);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblApeMat);
            this.Controls.Add(this.LblApePat);
            this.Controls.Add(this.TbxNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.DgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientes";
            this.Text = "FrmClientes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TextBox TbxID;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox TbxDomicilio;
        private System.Windows.Forms.TextBox TbxTelefono;
        private System.Windows.Forms.TextBox TbxApemat;
        private System.Windows.Forms.TextBox TbxApepat;
        private System.Windows.Forms.Label LblCalle;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblApeMat;
        private System.Windows.Forms.Label LblApePat;
        private System.Windows.Forms.TextBox TbxNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView DgvClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apepat;
        private System.Windows.Forms.DataGridViewTextBoxColumn apemat;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitecredito;
        private System.Windows.Forms.TextBox TbxColonia;
        private System.Windows.Forms.Label LblColonia;
        private System.Windows.Forms.TextBox TbxLimiteCredito;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnReporte;
    }
}