using MongoDB.Bson;
using MongoDB.Driver;
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
                btnEliminar.Visible = true;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Mensaje de aviso preguntando si realmente desea borrar el resumen
            DialogResult result = MessageBox.Show("¿Realmente desea eliminar este resumen?, Se perdera permanentemente", "Aviso!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    //Coneccion con mongoDB
                    String connectionstr = "mongodb://localhost";
                    MongoClient client = new MongoClient(connectionstr);

                    IMongoDatabase DB = client.GetDatabase("ResumenesMundial");

                    //Obtiene la coleccion de Afincionados
                    var Resumenes = DB.GetCollection<ClaseResumen>("ResumenPartido");
                    
                    //Actualizar Imagen
                    Resumenes.DeleteOne(o => o.numero_partido == ResumenSeleccionado.numero_partido);

                    MessageBox.Show("Se ha eliminado exitosamente", "Aviso");

                    this.Close();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Se produjo un error al borrar su cuenta, Error: \n" + er.ToString(), "Error");
                }
            }
        }
    }
}
