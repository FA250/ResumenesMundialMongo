using ResumenMundialMongo.BD;
using System;
using System.Collections;
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

        private void btnResumen_Click(object sender, EventArgs e)
        {
            if (txtSeleccionarResumen.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el número de partido", "Error");
            }
            else
            {
                ClaseMD MD = new ClaseMD();
                ArrayList Partidos = MD.Select_Todos_Partidos();
                bool PartidoExiste = false;
                foreach (ArrayList Partido in Partidos)
                {
                    if (Partido[0].ToString() == txtSeleccionarResumen.Text)
                    {
                        PartidoExiste = true;
                    }
                }
                if (PartidoExiste)
                {
                    frmMostrarResumen Resumen = new frmMostrarResumen();
                    Resumen.Show();
                }
                else
                {
                    MessageBox.Show("El partido ingresado no existe", "Error");
                }
            }
        }
    }
}
