namespace ResumenMundialMongo
{
    partial class frmMostrarResumen
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumeroPartido = new System.Windows.Forms.Label();
            this.lblEquipos = new System.Windows.Forms.Label();
            this.lblResumen = new System.Windows.Forms.Label();
            this.btnComentarios = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbVideos = new System.Windows.Forms.ComboBox();
            this.btnMostrarVideo = new System.Windows.Forms.Button();
            this.btnModificarResumen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(270, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Equipos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(29, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Número Partido";
            // 
            // lblNumeroPartido
            // 
            this.lblNumeroPartido.AutoSize = true;
            this.lblNumeroPartido.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPartido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.lblNumeroPartido.Location = new System.Drawing.Point(186, 21);
            this.lblNumeroPartido.Name = "lblNumeroPartido";
            this.lblNumeroPartido.Size = new System.Drawing.Size(22, 28);
            this.lblNumeroPartido.TabIndex = 18;
            this.lblNumeroPartido.Text = "0";
            // 
            // lblEquipos
            // 
            this.lblEquipos.AutoSize = true;
            this.lblEquipos.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEquipos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.lblEquipos.Location = new System.Drawing.Point(378, 21);
            this.lblEquipos.Name = "lblEquipos";
            this.lblEquipos.Size = new System.Drawing.Size(45, 28);
            this.lblEquipos.TabIndex = 17;
            this.lblEquipos.Text = "A-B";
            // 
            // lblResumen
            // 
            this.lblResumen.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.lblResumen.Location = new System.Drawing.Point(29, 76);
            this.lblResumen.Name = "lblResumen";
            this.lblResumen.Size = new System.Drawing.Size(771, 509);
            this.lblResumen.TabIndex = 17;
            this.lblResumen.Text = "Resumen\r";
            // 
            // btnComentarios
            // 
            this.btnComentarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.btnComentarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComentarios.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComentarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.btnComentarios.Location = new System.Drawing.Point(622, 639);
            this.btnComentarios.Name = "btnComentarios";
            this.btnComentarios.Size = new System.Drawing.Size(165, 33);
            this.btnComentarios.TabIndex = 23;
            this.btnComentarios.Text = "Comentarios";
            this.btnComentarios.UseVisualStyleBackColor = false;
            this.btnComentarios.Click += new System.EventHandler(this.btnComentarios_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(4, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 28);
            this.label2.TabIndex = 25;
            this.label2.Text = "Video";
            // 
            // cmbVideos
            // 
            this.cmbVideos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVideos.FormattingEnabled = true;
            this.cmbVideos.Location = new System.Drawing.Point(73, 603);
            this.cmbVideos.Name = "cmbVideos";
            this.cmbVideos.Size = new System.Drawing.Size(173, 21);
            this.cmbVideos.TabIndex = 26;
            this.cmbVideos.SelectedIndexChanged += new System.EventHandler(this.cmbVideos_SelectedIndexChanged);
            // 
            // btnMostrarVideo
            // 
            this.btnMostrarVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.btnMostrarVideo.Enabled = false;
            this.btnMostrarVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarVideo.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarVideo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.btnMostrarVideo.Location = new System.Drawing.Point(43, 633);
            this.btnMostrarVideo.Name = "btnMostrarVideo";
            this.btnMostrarVideo.Size = new System.Drawing.Size(165, 33);
            this.btnMostrarVideo.TabIndex = 23;
            this.btnMostrarVideo.Text = "Ver Video";
            this.btnMostrarVideo.UseVisualStyleBackColor = false;
            this.btnMostrarVideo.Click += new System.EventHandler(this.btnMostrarVideo_Click);
            // 
            // btnModificarResumen
            // 
            this.btnModificarResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.btnModificarResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarResumen.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.btnModificarResumen.Location = new System.Drawing.Point(345, 639);
            this.btnModificarResumen.Name = "btnModificarResumen";
            this.btnModificarResumen.Size = new System.Drawing.Size(165, 33);
            this.btnModificarResumen.TabIndex = 23;
            this.btnModificarResumen.Text = "Modificar";
            this.btnModificarResumen.UseVisualStyleBackColor = false;
            this.btnModificarResumen.Visible = false;
            this.btnModificarResumen.Click += new System.EventHandler(this.btnModificarResumen_Click);
            // 
            // frmMostrarResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(812, 684);
            this.Controls.Add(this.lblResumen);
            this.Controls.Add(this.cmbVideos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnModificarResumen);
            this.Controls.Add(this.btnMostrarVideo);
            this.Controls.Add(this.btnComentarios);
            this.Controls.Add(this.lblEquipos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumeroPartido);
            this.Controls.Add(this.label3);
            this.Name = "frmMostrarResumen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Resumen";
            this.Load += new System.EventHandler(this.frmMostrarResumen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumeroPartido;
        private System.Windows.Forms.Label lblEquipos;
        private System.Windows.Forms.Label lblResumen;
        private System.Windows.Forms.Button btnComentarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbVideos;
        private System.Windows.Forms.Button btnMostrarVideo;
        private System.Windows.Forms.Button btnModificarResumen;
    }
}