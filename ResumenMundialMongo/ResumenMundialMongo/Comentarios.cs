using MongoDB.Bson;
using MongoDB.Driver;
using ResumenMundialMongo.Clases;
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
    }
}
