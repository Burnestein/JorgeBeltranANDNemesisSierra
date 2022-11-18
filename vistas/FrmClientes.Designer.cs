
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
            this.TbxCalle = new System.Windows.Forms.TextBox();
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
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cbxusuarios = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnLimpiar.Location = new System.Drawing.Point(144, 287);
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
            this.TbxID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxID.Location = new System.Drawing.Point(232, 44);
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
            this.LblID.Location = new System.Drawing.Point(53, 42);
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
            this.BtnEliminar.Location = new System.Drawing.Point(631, 287);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(94, 34);
            this.BtnEliminar.TabIndex = 32;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnModificar.Location = new System.Drawing.Point(497, 287);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(94, 34);
            this.BtnModificar.TabIndex = 31;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnInsertar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnInsertar.Location = new System.Drawing.Point(385, 287);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(94, 34);
            this.BtnInsertar.TabIndex = 30;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnActualizar.Location = new System.Drawing.Point(264, 287);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(94, 34);
            this.BtnActualizar.TabIndex = 29;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // TbxCalle
            // 
            this.TbxCalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxCalle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxCalle.Location = new System.Drawing.Point(232, 224);
            this.TbxCalle.Name = "TbxCalle";
            this.TbxCalle.Size = new System.Drawing.Size(204, 23);
            this.TbxCalle.TabIndex = 28;
            // 
            // TbxTelefono
            // 
            this.TbxTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxTelefono.Location = new System.Drawing.Point(232, 190);
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
            this.TbxApemat.Location = new System.Drawing.Point(232, 153);
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
            this.TbxApepat.Location = new System.Drawing.Point(232, 118);
            this.TbxApepat.Name = "TbxApepat";
            this.TbxApepat.Size = new System.Drawing.Size(204, 23);
            this.TbxApepat.TabIndex = 25;
            // 
            // LblCalle
            // 
            this.LblCalle.AutoSize = true;
            this.LblCalle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblCalle.Location = new System.Drawing.Point(53, 224);
            this.LblCalle.Name = "LblCalle";
            this.LblCalle.Size = new System.Drawing.Size(46, 17);
            this.LblCalle.TabIndex = 24;
            this.LblCalle.Text = "Calle:";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblTelefono.Location = new System.Drawing.Point(53, 188);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(66, 17);
            this.LblTelefono.TabIndex = 23;
            this.LblTelefono.Text = "Teléfono:";
            // 
            // LblApeMat
            // 
            this.LblApeMat.AutoSize = true;
            this.LblApeMat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblApeMat.Location = new System.Drawing.Point(53, 153);
            this.LblApeMat.Name = "LblApeMat";
            this.LblApeMat.Size = new System.Drawing.Size(125, 17);
            this.LblApeMat.TabIndex = 22;
            this.LblApeMat.Text = "Apellido materno:";
            // 
            // LblApePat
            // 
            this.LblApePat.AutoSize = true;
            this.LblApePat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblApePat.Location = new System.Drawing.Point(53, 116);
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
            this.TbxNombre.Location = new System.Drawing.Point(232, 77);
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
            this.LblNombre.Location = new System.Drawing.Point(53, 77);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(65, 17);
            this.LblNombre.TabIndex = 19;
            this.LblNombre.Text = "Nombre:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JorgeBeltranANDNemesisSierra.Properties.Resources.nasa;
            this.pictureBox1.Location = new System.Drawing.Point(549, 44);
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
            this.telefono,
            this.calle});
            this.DgvClientes.Location = new System.Drawing.Point(107, 340);
            this.DgvClientes.Name = "DgvClientes";
            this.DgvClientes.Size = new System.Drawing.Size(646, 150);
            this.DgvClientes.TabIndex = 38;
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
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            // 
            // Cbxusuarios
            // 
            this.Cbxusuarios.FormattingEnabled = true;
            this.Cbxusuarios.Location = new System.Drawing.Point(315, 253);
            this.Cbxusuarios.Name = "Cbxusuarios";
            this.Cbxusuarios.Size = new System.Drawing.Size(121, 21);
            this.Cbxusuarios.TabIndex = 39;
            // 
            // FrmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 517);
            this.Controls.Add(this.Cbxusuarios);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TbxID);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.TbxCalle);
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
            this.Load += new System.EventHandler(this.FrmClientes_Load);
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
        private System.Windows.Forms.TextBox TbxCalle;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.ComboBox Cbxusuarios;
    }
}