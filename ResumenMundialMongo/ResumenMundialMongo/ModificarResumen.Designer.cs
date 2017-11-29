namespace ResumenMundialMongo
{
    partial class frmModificarResumen
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
            this.txtTextoResumen = new System.Windows.Forms.TextBox();
            this.btnModificarResumen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTextoResumen
            // 
            this.txtTextoResumen.Location = new System.Drawing.Point(12, 12);
            this.txtTextoResumen.MaxLength = 100000;
            this.txtTextoResumen.Multiline = true;
            this.txtTextoResumen.Name = "txtTextoResumen";
            this.txtTextoResumen.Size = new System.Drawing.Size(521, 308);
            this.txtTextoResumen.TabIndex = 18;
            // 
            // btnModificarResumen
            // 
            this.btnModificarResumen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(52)))), ((int)(((byte)(103)))));
            this.btnModificarResumen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarResumen.Font = new System.Drawing.Font("Minion Pro", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarResumen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(224)))), ((int)(((byte)(48)))));
            this.btnModificarResumen.Location = new System.Drawing.Point(185, 335);
            this.btnModificarResumen.Name = "btnModificarResumen";
            this.btnModificarResumen.Size = new System.Drawing.Size(165, 33);
            this.btnModificarResumen.TabIndex = 23;
            this.btnModificarResumen.Text = "Modificar";
            this.btnModificarResumen.UseVisualStyleBackColor = false;
            this.btnModificarResumen.Click += new System.EventHandler(this.btnModificarResumen_Click);
            // 
            // frmModificarResumen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(545, 380);
            this.Controls.Add(this.btnModificarResumen);
            this.Controls.Add(this.txtTextoResumen);
            this.Name = "frmModificarResumen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModificarResumen";
            this.Load += new System.EventHandler(this.frmModificarResumen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTextoResumen;
        private System.Windows.Forms.Button btnModificarResumen;
    }
}