
namespace JorgeBeltranANDNemesisSierra
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnConectar = new System.Windows.Forms.Button();
            this.LblLogin = new System.Windows.Forms.Label();
            this.TbxUsuario = new System.Windows.Forms.TextBox();
            this.TbxContrasena = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.Lbl_Contrasena = new System.Windows.Forms.Label();
            this.Pbx_Imagen = new System.Windows.Forms.PictureBox();
            this.Pnl_Lateral = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Imagen)).BeginInit();
            this.Pnl_Lateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnConectar
            // 
            this.BtnConectar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.BtnConectar.FlatAppearance.BorderSize = 0;
            this.BtnConectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.BtnConectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConectar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnConectar.Location = new System.Drawing.Point(350, 157);
            this.BtnConectar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(365, 40);
            this.BtnConectar.TabIndex = 0;
            this.BtnConectar.Text = "ACCEDER";
            this.BtnConectar.UseVisualStyleBackColor = false;
            this.BtnConectar.UseWaitCursor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // LblLogin
            // 
            this.LblLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.ForeColor = System.Drawing.Color.DimGray;
            this.LblLogin.Location = new System.Drawing.Point(487, 8);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(100, 33);
            this.LblLogin.TabIndex = 22;
            this.LblLogin.Text = "LOGIN";
            this.LblLogin.UseWaitCursor = true;
            // 
            // TbxUsuario
            // 
            this.TbxUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TbxUsuario.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.TbxUsuario.Location = new System.Drawing.Point(350, 67);
            this.TbxUsuario.Name = "TbxUsuario";
            this.TbxUsuario.Size = new System.Drawing.Size(366, 27);
            this.TbxUsuario.TabIndex = 17;
            this.TbxUsuario.UseWaitCursor = true;
            // 
            // TbxContrasena
            // 
            this.TbxContrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TbxContrasena.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TbxContrasena.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxContrasena.ForeColor = System.Drawing.Color.DimGray;
            this.TbxContrasena.Location = new System.Drawing.Point(350, 104);
            this.TbxContrasena.Name = "TbxContrasena";
            this.TbxContrasena.Size = new System.Drawing.Size(365, 27);
            this.TbxContrasena.TabIndex = 18;
            this.TbxContrasena.UseWaitCursor = true;
            // 
            // LblUser
            // 
            this.LblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.SystemColors.Control;
            this.LblUser.Location = new System.Drawing.Point(250, 68);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(67, 20);
            this.LblUser.TabIndex = 19;
            this.LblUser.Text = "Usuario:";
            this.LblUser.UseWaitCursor = true;
            // 
            // Lbl_Contrasena
            // 
            this.Lbl_Contrasena.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Contrasena.AutoSize = true;
            this.Lbl_Contrasena.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Contrasena.ForeColor = System.Drawing.SystemColors.Control;
            this.Lbl_Contrasena.Location = new System.Drawing.Point(247, 108);
            this.Lbl_Contrasena.Name = "Lbl_Contrasena";
            this.Lbl_Contrasena.Size = new System.Drawing.Size(99, 20);
            this.Lbl_Contrasena.TabIndex = 20;
            this.Lbl_Contrasena.Text = "Contraseña:";
            this.Lbl_Contrasena.UseWaitCursor = true;
            // 
            // Pbx_Imagen
            // 
            this.Pbx_Imagen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pbx_Imagen.Image = global::JorgeBeltranANDNemesisSierra.Properties.Resources.logo_nasa;
            this.Pbx_Imagen.Location = new System.Drawing.Point(3, 88);
            this.Pbx_Imagen.Name = "Pbx_Imagen";
            this.Pbx_Imagen.Size = new System.Drawing.Size(197, 141);
            this.Pbx_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Imagen.TabIndex = 9;
            this.Pbx_Imagen.TabStop = false;
            this.Pbx_Imagen.UseWaitCursor = true;
            // 
            // Pnl_Lateral
            // 
            this.Pnl_Lateral.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pnl_Lateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Pnl_Lateral.Controls.Add(this.Pbx_Imagen);
            this.Pnl_Lateral.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Lateral.Name = "Pnl_Lateral";
            this.Pnl_Lateral.Size = new System.Drawing.Size(200, 301);
            this.Pnl_Lateral.TabIndex = 21;
            this.Pnl_Lateral.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(764, 301);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.Pnl_Lateral);
            this.Controls.Add(this.Lbl_Contrasena);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.TbxContrasena);
            this.Controls.Add(this.TbxUsuario);
            this.Controls.Add(this.BtnConectar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Login";
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Imagen)).EndInit();
            this.Pnl_Lateral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.TextBox TbxUsuario;
        private System.Windows.Forms.TextBox TbxContrasena;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label Lbl_Contrasena;
        private System.Windows.Forms.PictureBox Pbx_Imagen;
        private System.Windows.Forms.Panel Pnl_Lateral;
    }
}

