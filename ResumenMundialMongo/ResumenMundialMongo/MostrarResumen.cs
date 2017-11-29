using MongoDB.Bson;
using ResumenMundialMongo.Clases;
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
    public partial class frmMostrarResumen : Form
    {
        ClaseResumen ResumenSeleccionado = new ClaseResumen();
        bool Admin;
        String aficionadoActual="";
        public frmMostrarResumen(ClaseResumen Resumen,bool Administrador, String Codigo_Aficionado)
        {
            InitializeComponent();
            ResumenSeleccionado = Resumen;
            Admin = Administrador;
            aficionadoActual = Codigo_Aficionado;
        }

        private void btnComentarios_Click(object sender, EventArgs e)
        {
            frmComentarios Comentario = new frmComentarios(ResumenSeleccionado.numero_partido, aficionadoActual);
            Comentario.Show();
        }

        private void frmMostrarResumen_Load(object sender, EventArgs e)
        {
            if (Admin)
            {
                btnModificarResumen.Visible = true;
            }
            lblNumeroPartido.Text = ResumenSeleccionado.numero_partido.ToString();
            lblEquipos.Text = ResumenSeleccionado.equipos;
            lblResumen.Text = ResumenSeleccionado.mensaje;
            int cont=1;
            List<ClaseVideo> Videos= ResumenSeleccionado.videos;
            foreach (ClaseVideo V in Videos)
            {
                cmbVideos.Items.Add(cont);
                cont++;
            }
        }

        private void btnMostrarVideo_Click(object sender, EventArgs e)
        {
            List<ClaseVideo> Videos = ResumenSeleccionado.videos;
            foreach (ClaseVideo V in Videos)
            {
                if (V.codigoV == Convert.ToInt32(cmbVideos.Text))
                {
                    frmMostrarVideo Video = new frmMostrarVideo(V.video);
                    Video.Show();
                }
            }
        }

        private void cmbVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnMostrarVideo.Enabled = true;
        }

        private void btnModificarResumen_Click(object sender, EventArgs e)
        {
            frmModificarResumen ModResumen = new frmModificarResumen(ResumenSeleccionado.mensaje, ResumenSeleccionado.numero_partido);
            ModResumen.Show();
            this.Close();
        }
    }
}
