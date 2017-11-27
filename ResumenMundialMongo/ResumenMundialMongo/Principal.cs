using ResumenMundialMongo.BD;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResumenMundialMongo
{
    public partial class frmPrincipalAdmin : Form
    {
        ClaseAficionado AficionadoLogeado;
        public frmPrincipalAdmin(ClaseAficionado Aficionado)
        {
            InitializeComponent();
            AficionadoLogeado = Aficionado;
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

        private void frmPrincipalAdmin_Load(object sender, EventArgs e)
        {
            //Mostrar configuracion guardada
            if (AficionadoLogeado.mostrar_correo)
            {
                chkbCorreo.Checked = true;
            }
            if (AficionadoLogeado.mostrar_foto)
            {
                chkbFoto.Checked = true;
            }
            //Mostrar imagen guardada
            byte[] picture = AficionadoLogeado.foto;
            pctbImagenPerfil.Image = Image.FromStream(new MemoryStream(picture));
            pctbImagenPerfil.Refresh();
        }
    }
}
