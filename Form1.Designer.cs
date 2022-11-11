
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
            this.BtnConectar = new System.Windows.Forms.Button();
            this.TbxUsuario = new System.Windows.Forms.TextBox();
            this.TbxContrasena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Contrasena = new System.Windows.Forms.Label();
            this.Pbx_Imagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(356, 159);
            this.BtnConectar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(102, 36);
            this.BtnConectar.TabIndex = 0;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // TbxUsuario
            // 
            this.TbxUsuario.Location = new System.Drawing.Point(356, 60);
            this.TbxUsuario.Name = "TbxUsuario";
            this.TbxUsuario.Size = new System.Drawing.Size(180, 20);
            this.TbxUsuario.TabIndex = 1;
            // 
            // TbxContrasena
            // 
            this.TbxContrasena.Location = new System.Drawing.Point(356, 106);
            this.TbxContrasena.Name = "TbxContrasena";
            this.TbxContrasena.Size = new System.Drawing.Size(180, 20);
            this.TbxContrasena.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // Lbl_Contrasena
            // 
            this.Lbl_Contrasena.AutoSize = true;
            this.Lbl_Contrasena.Location = new System.Drawing.Point(259, 113);
            this.Lbl_Contrasena.Name = "Lbl_Contrasena";
            this.Lbl_Contrasena.Size = new System.Drawing.Size(64, 13);
            this.Lbl_Contrasena.TabIndex = 4;
            this.Lbl_Contrasena.Text = "Contraseña:";
            // 
            // Pbx_Imagen
            // 
            this.Pbx_Imagen.Location = new System.Drawing.Point(90, 60);
            this.Pbx_Imagen.Name = "Pbx_Imagen";
            this.Pbx_Imagen.Size = new System.Drawing.Size(141, 120);
            this.Pbx_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pbx_Imagen.TabIndex = 5;
            this.Pbx_Imagen.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 269);
            this.Controls.Add(this.Pbx_Imagen);
            this.Controls.Add(this.Lbl_Contrasena);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxContrasena);
            this.Controls.Add(this.TbxUsuario);
            this.Controls.Add(this.BtnConectar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pbx_Imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.TextBox TbxUsuario;
        private System.Windows.Forms.TextBox TbxContrasena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Contrasena;
        private System.Windows.Forms.PictureBox Pbx_Imagen;
    }
}

