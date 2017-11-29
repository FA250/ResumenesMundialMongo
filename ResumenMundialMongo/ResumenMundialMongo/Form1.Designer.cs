namespace ResumenMundialMongo
{
    partial class frmIngreso
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.txtIngresoCod = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngresoContrasena = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegistroCod = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRegistroContrasena = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegistroCorreo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pctbImagenPerfil = new System.Windows.Forms.PictureBox();
            this.btnElegirFoto = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctbImagenPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.btnIngresar.Location = new System.Drawing.Point(620, 173);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(165, 33);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.label.Location = new System.Drawing.Point(495, 57);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(75, 28);
            this.label.TabIndex = 10;
            this.label.Text = "Código";
            // 
            // txtIngresoCod
            // 
            this.txtIngresoCod.Location = new System.Drawing.Point(609, 61);
            this.txtIngresoCod.MaxLength = 15;
            this.txtIngresoCod.Name = "txtIngresoCod";
            this.txtIngresoCod.Size = new System.Drawing.Size(238, 20);
            this.txtIngresoCod.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(495, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Contraseña";
            // 
            // txtIngresoContrasena
            // 
            this.txtIngresoContrasena.Location = new System.Drawing.Point(609, 98);
            this.txtIngresoContrasena.MaxLength = 15;
            this.txtIngresoContrasena.Name = "txtIngresoContrasena";
            this.txtIngresoContrasena.PasswordChar = '*';
            this.txtIngresoContrasena.Size = new System.Drawing.Size(238, 20);
            this.txtIngresoContrasena.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(358, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 10;
            this.label2.Text = "Aficionados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(21, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Código";
            // 
            // txtRegistroCod
            // 
            this.txtRegistroCod.Location = new System.Drawing.Point(206, 63);
            this.txtRegistroCod.MaxLength = 15;
            this.txtRegistroCod.Name = "txtRegistroCod";
            this.txtRegistroCod.Size = new System.Drawing.Size(238, 20);
            this.txtRegistroCod.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.label4.Location = new System.Drawing.Point(21, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña";
            // 
            // txtRegistroContrasena
            // 
            this.txtRegistroContrasena.Location = new System.Drawing.Point(206, 89);
            this.txtRegistroContrasena.MaxLength = 15;
            this.txtRegistroContrasena.Name = "txtRegistroContrasena";
            this.txtRegistroContrasena.PasswordChar = '*';
            this.txtRegistroContrasena.Size = new System.Drawing.Size(238, 20);
            this.txtRegistroContrasena.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.label5.Location = new System.Drawing.Point(21, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 28);
            this.label5.TabIndex = 10;
            this.label5.Text = "Foto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.label6.Location = new System.Drawing.Point(21, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 28);
            this.label6.TabIndex = 10;
            this.label6.Text = "Correo Electrónico";
            // 
            // txtRegistroCorreo
            // 
            this.txtRegistroCorreo.Location = new System.Drawing.Point(206, 115);
            this.txtRegistroCorreo.MaxLength = 1000;
            this.txtRegistroCorreo.Name = "txtRegistroCorreo";
            this.txtRegistroCorreo.Size = new System.Drawing.Size(238, 20);
            this.txtRegistroCorreo.TabIndex = 15;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.btnRegistrar.Location = new System.Drawing.Point(234, 261);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(165, 33);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pctbImagenPerfil
            // 
            this.pctbImagenPerfil.Image = global::ResumenMundialMongo.Properties.Resources.Persona;
            this.pctbImagenPerfil.Location = new System.Drawing.Point(26, 183);
            this.pctbImagenPerfil.Name = "pctbImagenPerfil";
            this.pctbImagenPerfil.Size = new System.Drawing.Size(178, 176);
            this.pctbImagenPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbImagenPerfil.TabIndex = 16;
            this.pctbImagenPerfil.TabStop = false;
            // 
            // btnElegirFoto
            // 
            this.btnElegirFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.btnElegirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnElegirFoto.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegirFoto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.btnElegirFoto.Location = new System.Drawing.Point(260, 152);
            this.btnElegirFoto.Name = "btnElegirFoto";
            this.btnElegirFoto.Size = new System.Drawing.Size(110, 33);
            this.btnElegirFoto.TabIndex = 9;
            this.btnElegirFoto.Text = "Elegir foto";
            this.btnElegirFoto.UseVisualStyleBackColor = false;
            this.btnElegirFoto.Click += new System.EventHandler(this.btnElegirFoto_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.btnAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyuda.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAyuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.btnAyuda.Location = new System.Drawing.Point(620, 261);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(165, 33);
            this.btnAyuda.TabIndex = 9;
            this.btnAyuda.Text = "Ayuda";
            this.btnAyuda.UseVisualStyleBackColor = false;
            this.btnAyuda.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // frmIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(865, 371);
            this.Controls.Add(this.pctbImagenPerfil);
            this.Controls.Add(this.txtRegistroCorreo);
            this.Controls.Add(this.txtRegistroContrasena);
            this.Controls.Add(this.txtIngresoContrasena);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRegistroCod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIngresoCod);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnElegirFoto);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnIngresar);
            this.Name = "frmIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIngreso_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pctbImagenPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtIngresoCod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngresoContrasena;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegistroCod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRegistroContrasena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRegistroCorreo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox pctbImagenPerfil;
        private System.Windows.Forms.Button btnElegirFoto;
        private System.Windows.Forms.Button btnAyuda;
    }
}

