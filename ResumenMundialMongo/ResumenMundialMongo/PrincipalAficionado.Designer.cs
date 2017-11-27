namespace ResumenMundialMongo
{
    partial class frmPrincipalAficionado
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
            this.btnAbrirResumen = new System.Windows.Forms.Button();
            this.txtSeleccionarResumen = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chkbFoto = new System.Windows.Forms.CheckBox();
            this.chkbCorreo = new System.Windows.Forms.CheckBox();
            this.btnCambiarFoto = new System.Windows.Forms.Button();
            this.pctbImagenPerfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctbImagenPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAbrirResumen
            // 
            this.btnAbrirResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.btnAbrirResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrirResumen.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.btnAbrirResumen.Location = new System.Drawing.Point(423, 112);
            this.btnAbrirResumen.Name = "btnAbrirResumen";
            this.btnAbrirResumen.Size = new System.Drawing.Size(165, 33);
            this.btnAbrirResumen.TabIndex = 22;
            this.btnAbrirResumen.Text = "Abrir resumen";
            this.btnAbrirResumen.UseVisualStyleBackColor = false;
            this.btnAbrirResumen.Click += new System.EventHandler(this.btnAbrirResumen_Click);
            // 
            // txtSeleccionarResumen
            // 
            this.txtSeleccionarResumen.Location = new System.Drawing.Point(388, 57);
            this.txtSeleccionarResumen.MaxLength = 15;
            this.txtSeleccionarResumen.Name = "txtSeleccionarResumen";
            this.txtSeleccionarResumen.Size = new System.Drawing.Size(238, 20);
            this.txtSeleccionarResumen.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.label6.Location = new System.Drawing.Point(437, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 28);
            this.label6.TabIndex = 20;
            this.label6.Text = "Número Partido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(87, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Configuración";
            // 
            // chkbFoto
            // 
            this.chkbFoto.AutoSize = true;
            this.chkbFoto.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.chkbFoto.Location = new System.Drawing.Point(83, 48);
            this.chkbFoto.Name = "chkbFoto";
            this.chkbFoto.Size = new System.Drawing.Size(133, 30);
            this.chkbFoto.TabIndex = 23;
            this.chkbFoto.Text = "Mostrar Foto";
            this.chkbFoto.UseVisualStyleBackColor = true;
            this.chkbFoto.Click += new System.EventHandler(this.chkbFoto_Click);
            // 
            // chkbCorreo
            // 
            this.chkbCorreo.AutoSize = true;
            this.chkbCorreo.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkbCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.chkbCorreo.Location = new System.Drawing.Point(83, 83);
            this.chkbCorreo.Name = "chkbCorreo";
            this.chkbCorreo.Size = new System.Drawing.Size(152, 30);
            this.chkbCorreo.TabIndex = 23;
            this.chkbCorreo.Text = "Mostrar Correo";
            this.chkbCorreo.UseVisualStyleBackColor = true;
            this.chkbCorreo.Click += new System.EventHandler(this.chkbCorreo_Click);
            // 
            // btnCambiarFoto
            // 
            this.btnCambiarFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.btnCambiarFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCambiarFoto.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.btnCambiarFoto.Location = new System.Drawing.Point(96, 117);
            this.btnCambiarFoto.Name = "btnCambiarFoto";
            this.btnCambiarFoto.Size = new System.Drawing.Size(129, 33);
            this.btnCambiarFoto.TabIndex = 24;
            this.btnCambiarFoto.Text = "Cambiar foto";
            this.btnCambiarFoto.UseVisualStyleBackColor = false;
            this.btnCambiarFoto.Click += new System.EventHandler(this.btnCambiarFoto_Click);
            // 
            // pctbImagenPerfil
            // 
            this.pctbImagenPerfil.Image = global::ResumenMundialMongo.Properties.Resources.Persona;
            this.pctbImagenPerfil.Location = new System.Drawing.Point(92, 156);
            this.pctbImagenPerfil.Name = "pctbImagenPerfil";
            this.pctbImagenPerfil.Size = new System.Drawing.Size(135, 112);
            this.pctbImagenPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbImagenPerfil.TabIndex = 25;
            this.pctbImagenPerfil.TabStop = false;
            // 
            // frmPrincipalAficionado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(701, 280);
            this.Controls.Add(this.pctbImagenPerfil);
            this.Controls.Add(this.btnCambiarFoto);
            this.Controls.Add(this.chkbCorreo);
            this.Controls.Add(this.chkbFoto);
            this.Controls.Add(this.btnAbrirResumen);
            this.Controls.Add(this.txtSeleccionarResumen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Name = "frmPrincipalAficionado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal Aficionado";
            this.Load += new System.EventHandler(this.frmPrincipalAficionado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbImagenPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirResumen;
        private System.Windows.Forms.TextBox txtSeleccionarResumen;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkbFoto;
        private System.Windows.Forms.CheckBox chkbCorreo;
        private System.Windows.Forms.Button btnCambiarFoto;
        private System.Windows.Forms.PictureBox pctbImagenPerfil;
    }
}