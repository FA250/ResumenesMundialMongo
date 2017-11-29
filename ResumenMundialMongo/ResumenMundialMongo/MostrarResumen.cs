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
        public frmMostrarResumen(ClaseResumen Resumen,bool Administrador)
        {
            InitializeComponent();
            ResumenSeleccionado = Resumen;
            Admin = Administrador;
        }

        private void btnComentarios_Click(object sender, EventArgs e)
        {

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
    }
}
