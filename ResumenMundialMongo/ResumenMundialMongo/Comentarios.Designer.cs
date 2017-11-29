namespace ResumenMundialMongo
{
    partial class frmComentarios
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
            this.btnComentar = new System.Windows.Forms.Button();
            this.txtComentarioNuevo = new System.Windows.Forms.TextBox();
            this.lstvComentarios = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnComentar
            // 
            this.btnComentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.btnComentar.Enabled = false;
            this.btnComentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComentar.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComentar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.btnComentar.Location = new System.Drawing.Point(917, 12);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(165, 60);
            this.btnComentar.TabIndex = 24;
            this.btnComentar.Text = "Comentar";
            this.btnComentar.UseVisualStyleBackColor = false;
            this.btnComentar.Click += new System.EventHandler(this.btnComentar_Click);
            // 
            // txtComentarioNuevo
            // 
            this.txtComentarioNuevo.Location = new System.Drawing.Point(13, 12);
            this.txtComentarioNuevo.Multiline = true;
            this.txtComentarioNuevo.Name = "txtComentarioNuevo";
            this.txtComentarioNuevo.Size = new System.Drawing.Size(898, 60);
            this.txtComentarioNuevo.TabIndex = 25;
            this.txtComentarioNuevo.TextChanged += new System.EventHandler(this.txtComentarioNuevo_TextChanged);
            // 
            // lstvComentarios
            // 
            this.lstvComentarios.Location = new System.Drawing.Point(13, 78);
            this.lstvComentarios.Name = "lstvComentarios";
            this.lstvComentarios.Size = new System.Drawing.Size(1069, 465);
            this.lstvComentarios.TabIndex = 26;
            this.lstvComentarios.UseCompatibleStateImageBehavior = false;
            // 
            // frmComentarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1094, 555);
            this.Controls.Add(this.lstvComentarios);
            this.Controls.Add(this.txtComentarioNuevo);
            this.Controls.Add(this.btnComentar);
            this.Name = "frmComentarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comentarios";
            this.Load += new System.EventHandler(this.frmComentarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComentar;
        private System.Windows.Forms.TextBox txtComentarioNuevo;
        private System.Windows.Forms.ListView lstvComentarios;
    }
}