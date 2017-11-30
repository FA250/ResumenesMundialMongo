namespace ResumenMundialMongo
{
    partial class frmResponderComentario
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
            this.lblCodigoAficionado = new System.Windows.Forms.Label();
            this.txtComentarioEditar = new System.Windows.Forms.TextBox();
            this.txtResponderComentario = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.pctbImagenPerfil = new System.Windows.Forms.PictureBox();
            this.btnResponder = new System.Windows.Forms.Button();
            this.lstvComentarios = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.pctbImagenPerfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodigoAficionado
            // 
            this.lblCodigoAficionado.AutoSize = true;
            this.lblCodigoAficionado.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoAficionado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.lblCodigoAficionado.Location = new System.Drawing.Point(12, 20);
            this.lblCodigoAficionado.Name = "lblCodigoAficionado";
            this.lblCodigoAficionado.Size = new System.Drawing.Size(56, 22);
            this.lblCodigoAficionado.TabIndex = 11;
            this.lblCodigoAficionado.Text = "Código";
            // 
            // txtComentarioEditar
            // 
            this.txtComentarioEditar.Enabled = false;
            this.txtComentarioEditar.Location = new System.Drawing.Point(12, 54);
            this.txtComentarioEditar.Multiline = true;
            this.txtComentarioEditar.Name = "txtComentarioEditar";
            this.txtComentarioEditar.Size = new System.Drawing.Size(1011, 60);
            this.txtComentarioEditar.TabIndex = 26;
            // 
            // txtResponderComentario
            // 
            this.txtResponderComentario.Location = new System.Drawing.Point(12, 461);
            this.txtResponderComentario.Multiline = true;
            this.txtResponderComentario.Name = "txtResponderComentario";
            this.txtResponderComentario.Size = new System.Drawing.Size(1011, 60);
            this.txtResponderComentario.TabIndex = 26;
            this.txtResponderComentario.TextChanged += new System.EventHandler(this.txtResponderComentario_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.btnModificar.Location = new System.Drawing.Point(937, 11);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(106, 36);
            this.btnModificar.TabIndex = 27;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Visible = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Red;
            this.btnEliminar.Location = new System.Drawing.Point(1049, 13);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(106, 35);
            this.btnEliminar.TabIndex = 27;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.lblCorreo.Location = new System.Drawing.Point(199, 20);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(56, 22);
            this.lblCorreo.TabIndex = 11;
            this.lblCorreo.Text = "Correo";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Minion Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.lblFecha.Location = new System.Drawing.Point(486, 20);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 22);
            this.lblFecha.TabIndex = 11;
            this.lblFecha.Text = "Fecha";
            // 
            // pctbImagenPerfil
            // 
            this.pctbImagenPerfil.Image = global::ResumenMundialMongo.Properties.Resources.Persona;
            this.pctbImagenPerfil.Location = new System.Drawing.Point(1029, 54);
            this.pctbImagenPerfil.Name = "pctbImagenPerfil";
            this.pctbImagenPerfil.Size = new System.Drawing.Size(126, 133);
            this.pctbImagenPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctbImagenPerfil.TabIndex = 28;
            this.pctbImagenPerfil.TabStop = false;
            // 
            // btnResponder
            // 
            this.btnResponder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.btnResponder.Enabled = false;
            this.btnResponder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResponder.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.btnResponder.Location = new System.Drawing.Point(1029, 461);
            this.btnResponder.Name = "btnResponder";
            this.btnResponder.Size = new System.Drawing.Size(126, 60);
            this.btnResponder.TabIndex = 29;
            this.btnResponder.Text = "Responder";
            this.btnResponder.UseVisualStyleBackColor = false;
            this.btnResponder.Click += new System.EventHandler(this.btnResponder_Click);
            // 
            // lstvComentarios
            // 
            this.lstvComentarios.Location = new System.Drawing.Point(12, 120);
            this.lstvComentarios.Name = "lstvComentarios";
            this.lstvComentarios.Size = new System.Drawing.Size(1011, 335);
            this.lstvComentarios.TabIndex = 30;
            this.lstvComentarios.UseCompatibleStateImageBehavior = false;
            // 
            // frmResponderComentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1167, 533);
            this.Controls.Add(this.lstvComentarios);
            this.Controls.Add(this.btnResponder);
            this.Controls.Add(this.pctbImagenPerfil);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtResponderComentario);
            this.Controls.Add(this.txtComentarioEditar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblCodigoAficionado);
            this.Name = "frmResponderComentario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Responder Comentario";
            this.Load += new System.EventHandler(this.ResponderComentario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctbImagenPerfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoAficionado;
        private System.Windows.Forms.TextBox txtComentarioEditar;
        private System.Windows.Forms.TextBox txtResponderComentario;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.PictureBox pctbImagenPerfil;
        private System.Windows.Forms.Button btnResponder;
        private System.Windows.Forms.ListView lstvComentarios;
    }
}