using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResumenMundialMongo
{
    public partial class frmPrincipalAdmin : Form
    {
        public frmPrincipalAdmin()
        {
            InitializeComponent();
        }
        String PathVideos = "";

        private void btnAgregarVideo_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Media Files|*.mpg;*.avi;*.wma;*.mov;*.wav;*.mp2;*.mp3|All Files|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // image file path  
                PathVideos += open.FileName +",";  
            }
            lblVideos.Text = PathVideos;
        }

        private void btnAbrirResumen_Click(object sender, EventArgs e)
        {
            frmMostrarResumen Resumen = new frmMostrarResumen();
            Resumen.Show();
        }
    }
}
