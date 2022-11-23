
namespace JorgeBeltranANDNemesisSierra.vistas
{
    partial class FrmProveedores
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
            this.TbxTelefono = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TbxEmpresa = new System.Windows.Forms.TextBox();
            this.LblEmpresa = new System.Windows.Forms.Label();
            this.PbxLogo = new System.Windows.Forms.PictureBox();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.TbxID = new System.Windows.Forms.TextBox();
            this.LblID = new System.Windows.Forms.Label();
            this.LblHeader = new System.Windows.Forms.Label();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.TbxDomicilio = new System.Windows.Forms.TextBox();
            this.TbxColonia = new System.Windows.Forms.TextBox();
            this.TbxApemat = new System.Windows.Forms.TextBox();
            this.TbxApepat = new System.Windows.Forms.TextBox();
            this.LblDomicilio = new System.Windows.Forms.Label();
            this.LblColonia = new System.Windows.Forms.Label();
            this.LblApemat = new System.Windows.Forms.Label();
            this.LblApepat = new System.Windows.Forms.Label();
            this.TbxNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.DgvProveedores = new System.Windows.Forms.DataGridView();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apepat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apemat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.limitecredito = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbxCorreo = new System.Windows.Forms.TextBox();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.BtnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // TbxTelefono
            // 
            this.TbxTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxTelefono.Location = new System.Drawing.Point(468, 77);
            this.TbxTelefono.Name = "TbxTelefono";
            this.TbxTelefono.Size = new System.Drawing.Size(182, 23);
            this.TbxTelefono.TabIndex = 91;
            // 
            // LblTelefono
            // 
            this.LblTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.Location = new System.Drawing.Point(474, 47);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(66, 17);
            this.LblTelefono.TabIndex = 90;
            this.LblTelefono.Text = "Teléfono:";
            // 
            // TbxEmpresa
            // 
            this.TbxEmpresa.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxEmpresa.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxEmpresa.Location = new System.Drawing.Point(192, 211);
            this.TbxEmpresa.Name = "TbxEmpresa";
            this.TbxEmpresa.Size = new System.Drawing.Size(261, 23);
            this.TbxEmpresa.TabIndex = 89;
            // 
            // LblEmpresa
            // 
            this.LblEmpresa.AutoSize = true;
            this.LblEmpresa.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblEmpresa.Location = new System.Drawing.Point(13, 217);
            this.LblEmpresa.Name = "LblEmpresa";
            this.LblEmpresa.Size = new System.Drawing.Size(67, 17);
            this.LblEmpresa.TabIndex = 88;
            this.LblEmpresa.Text = "Empresa:";
            // 
            // PbxLogo
            // 
            this.PbxLogo.Image = global::JorgeBeltranANDNemesisSierra.Properties.Resources.nasa;
            this.PbxLogo.Location = new System.Drawing.Point(684, 42);
            this.PbxLogo.Name = "PbxLogo";
            this.PbxLogo.Size = new System.Drawing.Size(247, 204);
            this.PbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PbxLogo.TabIndex = 86;
            this.PbxLogo.TabStop = false;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnLimpiar.Location = new System.Drawing.Point(196, 285);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(94, 34);
            this.BtnLimpiar.TabIndex = 85;
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
            this.TbxID.Location = new System.Drawing.Point(192, 44);
            this.TbxID.Name = "TbxID";
            this.TbxID.Size = new System.Drawing.Size(261, 23);
            this.TbxID.TabIndex = 84;
            // 
            // LblID
            // 
            this.LblID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(13, 42);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(25, 17);
            this.LblID.TabIndex = 83;
            this.LblID.Text = "ID:";
            // 
            // LblHeader
            // 
            this.LblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.Location = new System.Drawing.Point(370, 9);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(236, 25);
            this.LblHeader.TabIndex = 82;
            this.LblHeader.Text = "Datos de proveedores";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnEliminar.Location = new System.Drawing.Point(641, 285);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(94, 34);
            this.BtnEliminar.TabIndex = 81;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnModificar.Location = new System.Drawing.Point(522, 285);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(94, 34);
            this.BtnModificar.TabIndex = 80;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnInsertar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnInsertar.Location = new System.Drawing.Point(410, 285);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(94, 34);
            this.BtnInsertar.TabIndex = 79;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnActualizar.Location = new System.Drawing.Point(299, 285);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(94, 34);
            this.BtnActualizar.TabIndex = 78;
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
            this.TbxDomicilio.Location = new System.Drawing.Point(192, 182);
            this.TbxDomicilio.Name = "TbxDomicilio";
            this.TbxDomicilio.Size = new System.Drawing.Size(261, 23);
            this.TbxDomicilio.TabIndex = 77;
            // 
            // TbxColonia
            // 
            this.TbxColonia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxColonia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxColonia.Location = new System.Drawing.Point(196, 240);
            this.TbxColonia.Name = "TbxColonia";
            this.TbxColonia.Size = new System.Drawing.Size(257, 23);
            this.TbxColonia.TabIndex = 76;
            // 
            // TbxApemat
            // 
            this.TbxApemat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxApemat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxApemat.Location = new System.Drawing.Point(192, 153);
            this.TbxApemat.Name = "TbxApemat";
            this.TbxApemat.Size = new System.Drawing.Size(261, 23);
            this.TbxApemat.TabIndex = 75;
            // 
            // TbxApepat
            // 
            this.TbxApepat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxApepat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxApepat.Location = new System.Drawing.Point(192, 118);
            this.TbxApepat.Name = "TbxApepat";
            this.TbxApepat.Size = new System.Drawing.Size(261, 23);
            this.TbxApepat.TabIndex = 74;
            // 
            // LblDomicilio
            // 
            this.LblDomicilio.AutoSize = true;
            this.LblDomicilio.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblDomicilio.Location = new System.Drawing.Point(13, 182);
            this.LblDomicilio.Name = "LblDomicilio";
            this.LblDomicilio.Size = new System.Drawing.Size(73, 17);
            this.LblDomicilio.TabIndex = 73;
            this.LblDomicilio.Text = "Domicilio:";
            // 
            // LblColonia
            // 
            this.LblColonia.AutoSize = true;
            this.LblColonia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblColonia.Location = new System.Drawing.Point(13, 245);
            this.LblColonia.Name = "LblColonia";
            this.LblColonia.Size = new System.Drawing.Size(64, 17);
            this.LblColonia.TabIndex = 72;
            this.LblColonia.Text = "Colonia:";
            // 
            // LblApemat
            // 
            this.LblApemat.AutoSize = true;
            this.LblApemat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblApemat.Location = new System.Drawing.Point(13, 153);
            this.LblApemat.Name = "LblApemat";
            this.LblApemat.Size = new System.Drawing.Size(123, 17);
            this.LblApemat.TabIndex = 71;
            this.LblApemat.Text = "Apellido Materno:";
            // 
            // LblApepat
            // 
            this.LblApepat.AutoSize = true;
            this.LblApepat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblApepat.Location = new System.Drawing.Point(13, 116);
            this.LblApepat.Name = "LblApepat";
            this.LblApepat.Size = new System.Drawing.Size(120, 17);
            this.LblApepat.TabIndex = 70;
            this.LblApepat.Text = "Apellido Paterno:";
            // 
            // TbxNombre
            // 
            this.TbxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxNombre.Location = new System.Drawing.Point(192, 77);
            this.TbxNombre.Name = "TbxNombre";
            this.TbxNombre.Size = new System.Drawing.Size(261, 23);
            this.TbxNombre.TabIndex = 69;
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblNombre.Location = new System.Drawing.Point(13, 77);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(65, 17);
            this.LblNombre.TabIndex = 68;
            this.LblNombre.Text = "Nombre:";
            // 
            // DgvProveedores
            // 
            this.DgvProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.apepat,
            this.apemat,
            this.domicilio,
            this.colonia,
            this.telefono,
            this.nombre,
            this.limitecredito,
            this.correo});
            this.DgvProveedores.Location = new System.Drawing.Point(4, 325);
            this.DgvProveedores.Name = "DgvProveedores";
            this.DgvProveedores.Size = new System.Drawing.Size(967, 150);
            this.DgvProveedores.TabIndex = 87;
            this.DgvProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProveedores_CellClick);
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "ID ";
            this.id_usuario.Name = "id_usuario";
            // 
            // apepat
            // 
            this.apepat.HeaderText = "Nombre:";
            this.apepat.Name = "apepat";
            // 
            // apemat
            // 
            this.apemat.HeaderText = "Apellido Paterno:";
            this.apemat.Name = "apemat";
            // 
            // domicilio
            // 
            this.domicilio.HeaderText = "Apellido Materno:";
            this.domicilio.Name = "domicilio";
            // 
            // colonia
            // 
            this.colonia.HeaderText = "Domicilio";
            this.colonia.Name = "colonia";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Empresa";
            this.telefono.Name = "telefono";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Colonia";
            this.nombre.Name = "nombre";
            // 
            // limitecredito
            // 
            this.limitecredito.HeaderText = "Telefono";
            this.limitecredito.Name = "limitecredito";
            // 
            // correo
            // 
            this.correo.HeaderText = "Correo";
            this.correo.Name = "correo";
            // 
            // TbxCorreo
            // 
            this.TbxCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxCorreo.Location = new System.Drawing.Point(468, 154);
            this.TbxCorreo.Name = "TbxCorreo";
            this.TbxCorreo.Size = new System.Drawing.Size(182, 23);
            this.TbxCorreo.TabIndex = 93;
            // 
            // LblCorreo
            // 
            this.LblCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorreo.Location = new System.Drawing.Point(474, 124);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(57, 17);
            this.LblCorreo.TabIndex = 92;
            this.LblCorreo.Text = "Correo:";
            // 
            // BtnReporte
            // 
            this.BtnReporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnReporte.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnReporte.Location = new System.Drawing.Point(750, 285);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(94, 34);
            this.BtnReporte.TabIndex = 94;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // FrmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 478);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.TbxCorreo);
            this.Controls.Add(this.LblCorreo);
            this.Controls.Add(this.TbxTelefono);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.TbxEmpresa);
            this.Controls.Add(this.LblEmpresa);
            this.Controls.Add(this.PbxLogo);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TbxID);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.TbxDomicilio);
            this.Controls.Add(this.TbxColonia);
            this.Controls.Add(this.TbxApemat);
            this.Controls.Add(this.TbxApepat);
            this.Controls.Add(this.LblDomicilio);
            this.Controls.Add(this.LblColonia);
            this.Controls.Add(this.LblApemat);
            this.Controls.Add(this.LblApepat);
            this.Controls.Add(this.TbxNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.DgvProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProveedores";
            this.Text = "FrmProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.PbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbxTelefono;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TbxEmpresa;
        private System.Windows.Forms.Label LblEmpresa;
        private System.Windows.Forms.PictureBox PbxLogo;
        private System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.TextBox TbxID;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblHeader;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox TbxDomicilio;
        private System.Windows.Forms.TextBox TbxColonia;
        private System.Windows.Forms.TextBox TbxApemat;
        private System.Windows.Forms.TextBox TbxApepat;
        private System.Windows.Forms.Label LblDomicilio;
        private System.Windows.Forms.Label LblColonia;
        private System.Windows.Forms.Label LblApemat;
        private System.Windows.Forms.Label LblApepat;
        private System.Windows.Forms.TextBox TbxNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.DataGridView DgvProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn apepat;
        private System.Windows.Forms.DataGridViewTextBoxColumn apemat;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn limitecredito;
        private System.Windows.Forms.DataGridViewTextBoxColumn correo;
        private System.Windows.Forms.TextBox TbxCorreo;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.Button BtnReporte;
    }
}