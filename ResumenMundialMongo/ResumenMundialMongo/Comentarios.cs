using MongoDB.Bson;
using MongoDB.Driver;
using ResumenMundialMongo.Clases;
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
    public partial class frmComentarios : Form
    {
        String numeroPartidoSeleccionado;
        String aficionadoActual="";
        public frmComentarios(String numero_partido, String aficionado)
        {
            InitializeComponent();
            numeroPartidoSeleccionado = numero_partido;
            aficionadoActual = aficionado;
        }

        private void btnComentar_Click(object sender, EventArgs e)
        {
            //Coneccion con mongoDB
            String connectionstr = "mongodb://localhost";
            MongoClient client = new MongoClient(connectionstr);

            IMongoDatabase DB = client.GetDatabase("ResumenesMundial");

            //Obtiene la coleccion de Resumenes de Partido
            var Comentarios = DB.GetCollection<ClaseComentario>("Comentario");

            var ComentariosExistentes = Comentarios.AsQueryable().Where(comentario => comentario.numero_partido == numeroPartidoSeleccionado);
            int CantEncontrada = ComentariosExistentes.Count();

            BsonArray hilo =new BsonArray();
                        
            //Crea documento de Bson para insertar la coleccion en la BD
            BsonDocument NuevoComentario = new BsonDocument
                    {
                        { "numero_partido" , numeroPartidoSeleccionado},
                        { "numero_comentario" , CantEncontrada+1},
                        { "aficionado", aficionadoActual},
                        { "fecha", System.DateTime.Now},
                        { "mensaje", txtComentarioNuevo.Text},
                        { "hilo", hilo}
                        
                    };


            IMongoCollection<BsonDocument> Comentario = DB.GetCollection<BsonDocument>("Comentario");
            Comentario.InsertOne(NuevoComentario);

            MessageBox.Show("Se ha comentado de manera exitosa", "Aviso");

            lstvComentarios.Clear();
            ActualizarComentarios();               
        }

        private void txtComentarioNuevo_TextChanged(object sender, EventArgs e)
        {
            if (txtComentarioNuevo.Text.Trim() == "")
            {
                btnComentar.Enabled = false;
            }
            else
            {
                btnComentar.Enabled = true;
            }
        }

        private void frmComentarios_Load(object sender, EventArgs e)
        {
            ActualizarComentarios();
        }

        private void ActualizarComentarios()
        {
            //Coneccion con mongoDB
            String connectionstr = "mongodb://localhost";
            MongoClient client = new MongoClient(connectionstr);

            IMongoDatabase DB = client.GetDatabase("ResumenesMundial");

            //Obtiene la coleccion de Resumenes de Partido
            var Comentarios = DB.GetCollection<ClaseComentario>("Comentario");
            var ComentariosExistentes = Comentarios.AsQueryable().Where(comentario => comentario.numero_partido == numeroPartidoSeleccionado);

            //Propiedades listview
            lstvComentarios.View = View.Details;

            //Columnas
            lstvComentarios.Columns.Add("Aficionado", 100);
            lstvComentarios.Columns.Add("Comentario", 500);
            lstvComentarios.Columns.Add("Correo", 150);
            lstvComentarios.Columns.Add("Fecha", 150);

            ImageList imgs = new ImageList();

            //Agregar imagenes
            foreach (ClaseComentario Comentario in ComentariosExistentes)
            {
                //Obtiene la coleccion de aficionado
                var Aficionados = DB.GetCollection<ClaseAficionado>("Aficionado");
                var AficionadosSeleccionados = Aficionados.AsQueryable().Where(comentario => comentario.codigo == Comentario.aficionado);
                if (AficionadosSeleccionados.First().borrado)
                {
                    imgs.Images.Add(ResumenMundialMongo.Properties.Resources.Persona);   
                }
                else if (AficionadosSeleccionados.First().mostrar_foto)
                {
                    byte[] picture = AficionadosSeleccionados.First().foto;
                    imgs.Images.Add(Image.FromStream(new MemoryStream(picture)));
                }
                else
                {
                    imgs.Images.Add(ResumenMundialMongo.Properties.Resources.Persona);
                }
            }

            lstvComentarios.SmallImageList = imgs;

            //Agregar Comentarios
            int cont=0;
            foreach (ClaseComentario Comentario in ComentariosExistentes)
            {
                string[] ComentarioParaMostrar = new string[4];

                
                ComentarioParaMostrar[1] = Comentario.mensaje;

                //Obtiene la coleccion de aficionado
                var Aficionados = DB.GetCollection<ClaseAficionado>("Aficionado");
                var AficionadosSeleccionados = Aficionados.AsQueryable().Where(comentario => comentario.codigo == Comentario.aficionado);
                if (AficionadosSeleccionados.First().borrado)
                {
                    ComentarioParaMostrar[0] = "BORRADO";
                    ComentarioParaMostrar[2] = "BORRADO";
                }
                else if (AficionadosSeleccionados.First().mostrar_correo) 
                {
                    ComentarioParaMostrar[0] = AficionadosSeleccionados.First().codigo;
                    ComentarioParaMostrar[2] = AficionadosSeleccionados.First().correo_electronico;
                }
                else
                {
                    ComentarioParaMostrar[0] = AficionadosSeleccionados.First().codigo;
                    ComentarioParaMostrar[2] = "-";
                }

                ComentarioParaMostrar[3] = Comentario.fecha.ToString();

                ListViewItem itm = new ListViewItem(ComentarioParaMostrar);
                lstvComentarios.Items.Add(itm);

                cont++;
            }            
        }
    }
}
