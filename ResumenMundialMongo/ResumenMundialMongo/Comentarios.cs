using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
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
                        { "fecha", System.DateTime.UtcNow.ToLocalTime()},
                        { "mensaje", txtComentarioNuevo.Text},
                        { "hilo", hilo}
                        
                    };


            IMongoCollection<BsonDocument> Comentario = DB.GetCollection<BsonDocument>("Comentario");
            Comentario.InsertOne(NuevoComentario);

            MessageBox.Show("Se ha comentado de manera exitosa", "Aviso");
                        
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
            lstvComentarios.Clear();
            //Coneccion con mongoDB
            String connectionstr = "mongodb://localhost";
            MongoClient client = new MongoClient(connectionstr);

            IMongoDatabase DB = client.GetDatabase("ResumenesMundial");

            //Obtiene la coleccion de Resumenes de Partido
            var Comentarios = DB.GetCollection<ClaseComentario>("Comentario");
            var ComentariosExistentes = Comentarios.AsQueryable().Where(comentario => comentario.numero_partido == numeroPartidoSeleccionado).OrderByDescending(co => co.fecha);

            //Propiedades listview
            lstvComentarios.View = View.Details;

            //Columnas
            lstvComentarios.Columns.Add("Aficionado", 200);
            lstvComentarios.Columns.Add("Comentario", 500);
            lstvComentarios.Columns.Add("Correo", 150);
            lstvComentarios.Columns.Add("Fecha", 150);

            
            //Agregar imagenes

            var imgs = new ImageList();            
            
            int cont = 0;
            foreach (ClaseComentario Comentario in ComentariosExistentes)
            {
                //Obtiene la coleccion de aficionado
                var Aficionados = DB.GetCollection<ClaseAficionado>("Aficionado");
                var AficionadosSeleccionados = Aficionados.AsQueryable().Where(comentario => comentario.codigo == Comentario.aficionado);
                if (AficionadosSeleccionados.First().borrado)
                {
                    imgs.Images.Add(cont.ToString(),ResumenMundialMongo.Properties.Resources.Persona);   
                }
                else if (AficionadosSeleccionados.First().mostrar_foto)
                {
                    byte[] picture = AficionadosSeleccionados.First().foto;
                    imgs.Images.Add(cont.ToString(),Image.FromStream(new MemoryStream(picture)));
                }
                else
                {
                    imgs.Images.Add(cont.ToString(),ResumenMundialMongo.Properties.Resources.Persona);
                }
                cont++;
            }

            imgs.ImageSize = new Size(64, 76);
            imgs.ColorDepth = ColorDepth.Depth24Bit;
            lstvComentarios.SmallImageList = imgs;

            //Agregar Comentarios
            cont=0;
            foreach (ClaseComentario Comentario in ComentariosExistentes)
            {
                string[] ComentarioParaMostrar = new string[5];

                
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

                ComentarioParaMostrar[4] = Comentario.numero_comentario.ToString();

                var itm = new ListViewItem(ComentarioParaMostrar);                
                itm.ImageKey = cont.ToString();
                itm.Tag = AficionadosSeleccionados.First().codigo;                
                lstvComentarios.Items.Add(itm);
                cont++;
            }            
        }

        private void lstvComentarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstvComentarios.SelectedItems.Count == 0)
                return;

            ListViewItem item = lstvComentarios.SelectedItems[0];

            frmResponderComentario RComent = new frmResponderComentario(item.Tag.ToString(), item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, numeroPartidoSeleccionado, aficionadoActual, Convert.ToInt32(item.SubItems[4].Text));
            RComent.Owner = this;
            RComent.Show();

            
        }

        private void frmComentarios_Activated(object sender, EventArgs e)
        {
            ActualizarComentarios();
        }
    }
}
