
namespace JorgeBeltranANDNemesisSierra.vistas
{
    partial class FrmUsuarios
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
            this.TbxNumero = new System.Windows.Forms.TextBox();
            this.TbxApemat = new System.Windows.Forms.TextBox();
            this.TbxApepat = new System.Windows.Forms.TextBox();
            this.LblCalle = new System.Windows.Forms.Label();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.LblApeMat = new System.Windows.Forms.Label();
            this.LblApePat = new System.Windows.Forms.Label();
            this.TbxNombre = new System.Windows.Forms.TextBox();
            this.LblNombre = new System.Windows.Forms.Label();
            this.DgvUsuarios = new System.Windows.Forms.DataGridView();
            this.id_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apepat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apemat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colonia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCelular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxUsuario = new System.Windows.Forms.TextBox();
            this.TbxContrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbxNumCelular = new System.Windows.Forms.TextBox();
            this.TbxEstado = new System.Windows.Forms.TextBox();
            this.TbxColonia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnLimpiar.Location = new System.Drawing.Point(196, 296);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(94, 34);
            this.BtnLimpiar.TabIndex = 57;
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
            this.TbxID.Location = new System.Drawing.Point(161, 51);
            this.TbxID.Name = "TbxID";
            this.TbxID.Size = new System.Drawing.Size(240, 23);
            this.TbxID.TabIndex = 56;
            // 
            // LblID
            // 
            this.LblID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblID.AutoSize = true;
            this.LblID.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.Location = new System.Drawing.Point(17, 49);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(25, 17);
            this.LblID.TabIndex = 55;
            this.LblID.Text = "ID:";
            // 
            // LblHeader
            // 
            this.LblHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHeader.AutoSize = true;
            this.LblHeader.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeader.Location = new System.Drawing.Point(354, 18);
            this.LblHeader.Name = "LblHeader";
            this.LblHeader.Size = new System.Drawing.Size(187, 25);
            this.LblHeader.TabIndex = 54;
            this.LblHeader.Text = "Datos del usuario";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnEliminar.Location = new System.Drawing.Point(695, 296);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(94, 34);
            this.BtnEliminar.TabIndex = 53;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnModificar.Location = new System.Drawing.Point(574, 296);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(94, 34);
            this.BtnModificar.TabIndex = 52;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnInsertar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnInsertar.Location = new System.Drawing.Point(447, 296);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(94, 34);
            this.BtnInsertar.TabIndex = 51;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnActualizar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnActualizar.Location = new System.Drawing.Point(326, 296);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(94, 34);
            this.BtnActualizar.TabIndex = 50;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // TbxCalle
            // 
            this.TbxCalle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxCalle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxCalle.Location = new System.Drawing.Point(161, 258);
            this.TbxCalle.Name = "TbxCalle";
            this.TbxCalle.Size = new System.Drawing.Size(240, 23);
            this.TbxCalle.TabIndex = 49;
            // 
            // TbxNumero
            // 
            this.TbxNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxNumero.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxNumero.Location = new System.Drawing.Point(563, 52);
            this.TbxNumero.Name = "TbxNumero";
            this.TbxNumero.Size = new System.Drawing.Size(240, 23);
            this.TbxNumero.TabIndex = 48;
            // 
            // TbxApemat
            // 
            this.TbxApemat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxApemat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxApemat.Location = new System.Drawing.Point(161, 224);
            this.TbxApemat.Name = "TbxApemat";
            this.TbxApemat.Size = new System.Drawing.Size(240, 23);
            this.TbxApemat.TabIndex = 47;
            this.TbxApemat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxApemat_KeyPress);
            // 
            // TbxApepat
            // 
            this.TbxApepat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxApepat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxApepat.Location = new System.Drawing.Point(161, 189);
            this.TbxApepat.Name = "TbxApepat";
            this.TbxApepat.Size = new System.Drawing.Size(240, 23);
            this.TbxApepat.TabIndex = 46;
            this.TbxApepat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxApepat_KeyPress);
            // 
            // LblCalle
            // 
            this.LblCalle.AutoSize = true;
            this.LblCalle.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblCalle.Location = new System.Drawing.Point(17, 261);
            this.LblCalle.Name = "LblCalle";
            this.LblCalle.Size = new System.Drawing.Size(46, 17);
            this.LblCalle.TabIndex = 45;
            this.LblCalle.Text = "Calle:";
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblTelefono.Location = new System.Drawing.Point(419, 52);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(64, 17);
            this.LblTelefono.TabIndex = 44;
            this.LblTelefono.Text = "Número:";
            // 
            // LblApeMat
            // 
            this.LblApeMat.AutoSize = true;
            this.LblApeMat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblApeMat.Location = new System.Drawing.Point(17, 224);
            this.LblApeMat.Name = "LblApeMat";
            this.LblApeMat.Size = new System.Drawing.Size(125, 17);
            this.LblApeMat.TabIndex = 43;
            this.LblApeMat.Text = "Apellido materno:";
            // 
            // LblApePat
            // 
            this.LblApePat.AutoSize = true;
            this.LblApePat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblApePat.Location = new System.Drawing.Point(17, 187);
            this.LblApePat.Name = "LblApePat";
            this.LblApePat.Size = new System.Drawing.Size(121, 17);
            this.LblApePat.TabIndex = 42;
            this.LblApePat.Text = "Apellido paterno:";
            // 
            // TbxNombre
            // 
            this.TbxNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxNombre.Location = new System.Drawing.Point(161, 148);
            this.TbxNombre.Name = "TbxNombre";
            this.TbxNombre.Size = new System.Drawing.Size(240, 23);
            this.TbxNombre.TabIndex = 41;
            this.TbxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxNombre_KeyPress);
            // 
            // LblNombre
            // 
            this.LblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LblNombre.Location = new System.Drawing.Point(17, 148);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(65, 17);
            this.LblNombre.TabIndex = 40;
            this.LblNombre.Text = "Nombre:";
            // 
            // DgvUsuarios
            // 
            this.DgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_cliente,
            this.usuario,
            this.contrasena,
            this.nombre,
            this.apepat,
            this.apemat,
            this.calle,
            this.numero,
            this.colonia,
            this.estado,
            this.numCelular});
            this.DgvUsuarios.Location = new System.Drawing.Point(12, 336);
            this.DgvUsuarios.Name = "DgvUsuarios";
            this.DgvUsuarios.Size = new System.Drawing.Size(1146, 150);
            this.DgvUsuarios.TabIndex = 59;
            this.DgvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsuarios_CellClick);
            this.DgvUsuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DgvUsuarios_MouseClick);
            // 
            // id_cliente
            // 
            this.id_cliente.HeaderText = "ID ";
            this.id_cliente.Name = "id_cliente";
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Usuario";
            this.usuario.Name = "usuario";
            // 
            // contrasena
            // 
            this.contrasena.HeaderText = "Contraseña";
            this.contrasena.Name = "contrasena";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre ";
            this.nombre.Name = "nombre";
            // 
            // apepat
            // 
            this.apepat.HeaderText = "Apellido paterno";
            this.apepat.Name = "apepat";
            // 
            // apemat
            // 
            this.apemat.HeaderText = "Apellido materno";
            this.apemat.Name = "apemat";
            // 
            // calle
            // 
            this.calle.HeaderText = "Calle";
            this.calle.Name = "calle";
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.Name = "numero";
            // 
            // colonia
            // 
            this.colonia.HeaderText = "Colonia";
            this.colonia.Name = "colonia";
            // 
            // estado
            // 
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            // 
            // numCelular
            // 
            this.numCelular.HeaderText = "Número del celular";
            this.numCelular.Name = "numCelular";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Usuario:";
            // 
            // TbxUsuario
            // 
            this.TbxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxUsuario.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxUsuario.Location = new System.Drawing.Point(161, 84);
            this.TbxUsuario.Name = "TbxUsuario";
            this.TbxUsuario.Size = new System.Drawing.Size(240, 23);
            this.TbxUsuario.TabIndex = 61;
            // 
            // TbxContrasena
            // 
            this.TbxContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxContrasena.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxContrasena.Location = new System.Drawing.Point(161, 119);
            this.TbxContrasena.Name = "TbxContrasena";
            this.TbxContrasena.Size = new System.Drawing.Size(240, 23);
            this.TbxContrasena.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Contraseña:";
            // 
            // TbxNumCelular
            // 
            this.TbxNumCelular.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxNumCelular.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxNumCelular.Location = new System.Drawing.Point(563, 151);
            this.TbxNumCelular.Name = "TbxNumCelular";
            this.TbxNumCelular.Size = new System.Drawing.Size(240, 23);
            this.TbxNumCelular.TabIndex = 69;
            // 
            // TbxEstado
            // 
            this.TbxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxEstado.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxEstado.Location = new System.Drawing.Point(563, 117);
            this.TbxEstado.Name = "TbxEstado";
            this.TbxEstado.Size = new System.Drawing.Size(240, 23);
            this.TbxEstado.TabIndex = 68;
            this.TbxEstado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxEstado_KeyPress);
            // 
            // TbxColonia
            // 
            this.TbxColonia.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxColonia.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.TbxColonia.Location = new System.Drawing.Point(563, 82);
            this.TbxColonia.Name = "TbxColonia";
            this.TbxColonia.Size = new System.Drawing.Size(240, 23);
            this.TbxColonia.TabIndex = 67;
            this.TbxColonia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxColonia_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label3.Location = new System.Drawing.Point(420, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 66;
            this.label3.Text = "Número de celular:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label4.Location = new System.Drawing.Point(420, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 65;
            this.label4.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.label5.Location = new System.Drawing.Point(420, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 64;
            this.label5.Text = "Colonia:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JorgeBeltranANDNemesisSierra.Properties.Resources.nasa;
            this.pictureBox1.Location = new System.Drawing.Point(880, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // BtnReporte
            // 
            this.BtnReporte.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnReporte.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BtnReporte.Location = new System.Drawing.Point(818, 296);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(94, 34);
            this.BtnReporte.TabIndex = 71;
            this.BtnReporte.Text = "Reporte";
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // FrmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 517);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TbxNumCelular);
            this.Controls.Add(this.TbxEstado);
            this.Controls.Add(this.TbxColonia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbxContrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbxUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TbxID);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.LblHeader);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnInsertar);
            this.Controls.Add(this.BtnActualizar);
            this.Controls.Add(this.TbxCalle);
            this.Controls.Add(this.TbxNumero);
            this.Controls.Add(this.TbxApemat);
            this.Controls.Add(this.TbxApepat);
            this.Controls.Add(this.LblCalle);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblApeMat);
            this.Controls.Add(this.LblApePat);
            this.Controls.Add(this.TbxNombre);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.DgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuarios";
            this.Text = "Catálogo de Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox TbxNumero;
        private System.Windows.Forms.TextBox TbxApemat;
        private System.Windows.Forms.TextBox TbxApepat;
        private System.Windows.Forms.Label LblCalle;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.Label LblApeMat;
        private System.Windows.Forms.Label LblApePat;
        private System.Windows.Forms.TextBox TbxNombre;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.DataGridView DgvUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxUsuario;
        private System.Windows.Forms.TextBox TbxContrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxNumCelular;
        private System.Windows.Forms.TextBox TbxEstado;
        private System.Windows.Forms.TextBox TbxColonia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasena;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apepat;
        private System.Windows.Forms.DataGridViewTextBoxColumn apemat;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn colonia;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCelular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnReporte;
    }
}