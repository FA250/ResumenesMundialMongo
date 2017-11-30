using MongoDB.Bson;
using MongoDB.Driver;
using ResumenMundialMongo.Clases;
using System;
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
    public partial class frmResponderComentario : Form
    {
        String numeroPartidoSeleccionado;
        String aficionadoComentario = "", mensajeComentario = "", correoA = "", fechaC = "";
        String aficionadoActual = "";
        int Num_Comentario;
        public frmResponderComentario(String codigoAficionado, String comentario, String correo, String fecha, String numero_partido, String aficionadoAc,int numero_comentario)
        {
            InitializeComponent();
            aficionadoComentario = codigoAficionado;
            mensajeComentario = comentario;
            correoA = correo;
            fechaC = fecha;
            numeroPartidoSeleccionado = numero_partido;
            aficionadoActual = aficionadoAc;
            Num_Comentario = numero_comentario;
        }

        private void ResponderComentario_Load(object sender, EventArgs e)
        {
            if (aficionadoComentario == aficionadoActual || aficionadoActual=="Administrador")
            {
                btnEliminar.Visible = true;
                btnModificar.Visible = true;
                txtComentarioEditar.Enabled = true;
            }

            txtComentarioEditar.Text = mensajeComentario;
            lblCodigoAficionado.Text = aficionadoComentario;
            lblCorreo.Text = correoA;
            lblFecha.Text = fechaC;

            //Coneccion con mongoDB
            String connectionstr = "mongodb://localhost";
            MongoClient client = new MongoClient(connectionstr);

            IMongoDatabase DB = client.GetDatabase("ResumenesMundial");

            //Obtiene la coleccion de aficionado
            var Aficionados = DB.GetCollection<ClaseAficionado>("Aficionado");
            var AficionadosSeleccionados = Aficionados.AsQueryable().Where(comentario => comentario.codigo == aficionadoComentario);
                      
           
            if (AficionadosSeleccionados.First().borrado)
            {
                pctbImagenPerfil.Image=ResumenMundialMongo.Properties.Resources.Persona;
            }
            else if (AficionadosSeleccionados.First().mostrar_foto)
            {
                byte[] picture = AficionadosSeleccionados.First().foto;
                pctbImagenPerfil.Image= Image.FromStream(new MemoryStream(picture));
            }
            else
            {
                pctbImagenPerfil.Image = ResumenMundialMongo.Properties.Resources.Persona;
            }

            ActualizarComentarios();
        }

        private void txtResponderComentario_TextChanged(object sender, EventArgs e)
        {
            if (txtResponderComentario.Text.Trim() != "")
            {
                btnResponder.Enabled = true;
            }
            else
            {
                btnResponder.Enabled = false;
            }
        }

        private void btnResponder_Click(object sender, EventArgs e)
        {
            //Coneccion con mongoDB
            String connectionstr = "mongodb://localhost";
            MongoClient client = new MongoClient(connectionstr);

            IMongoDatabase DB = client.GetDatabase("ResumenesMundial");

            //Obtiene la coleccion de Resumenes de Partido
            var Comentarios = DB.GetCollection<ClaseComentario>("Comentario");

            var ComentariosExistentes = Comentarios.AsQueryable().Where(comentario => comentario.numero_partido == numeroPartidoSeleccionado && comentario.numero_comentario == Num_Comentario);
            int CantEncontrada = ComentariosExistentes.Count();

            List<ClaseComentario> hilo = new List<ClaseComentario>();

            //Crea documento de Bson para insertar la coleccion en la BD
            /*BsonDocument NuevoComentario = new BsonDocument
                    {
                        { "numero_partido" , numeroPartidoSeleccionado},
                        { "numero_comentario" , ComentariosExistentes.First().hilo.Count+1},
                        { "aficionado", aficionadoActual},
                        { "fecha", System.DateTime.UtcNow.ToLocalTime()},
                        { "mensaje", txtResponderComentario.Text},
                        { "hilo", hilo}                        
                    };*/

            ClaseComentario MMM = new ClaseComentario();
            MMM.numero_partido=numeroPartidoSeleccionado;
            MMM.numero_comentario= ComentariosExistentes.First().hilo.Count+1;
            MMM.aficionado=aficionadoActual;
            MMM.fecha= System.DateTime.UtcNow.ToLocalTime();
            MMM.mensaje=txtResponderComentario.Text;
            MMM.hilo = hilo;

            //variable para actualizar Comentario
            var hilo2 = ComentariosExistentes.First().hilo;
            hilo2.Add(MMM);
            var updateDef = Builders<ClaseComentario>.Update.Set(o => o.hilo, hilo2);

            //Actualizar Comentario
            var builder = Builders<ClaseComentario>.Filter;
            var filt = builder.Eq("numero_comentario", Num_Comentario) & builder.Eq("numero_partido", numeroPartidoSeleccionado);
            Comentarios.UpdateOne(filt, updateDef);

            MessageBox.Show("Se ha comentado de manera exitosa", "Aviso");

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
            var ComentariosExistentes1 = Comentarios.AsQueryable().Where(comentario => comentario.numero_partido == numeroPartidoSeleccionado && comentario.numero_comentario == Num_Comentario);
            var ComentariosExistentes = ComentariosExistentes1.First().hilo;


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
                    imgs.Images.Add(cont.ToString(), ResumenMundialMongo.Properties.Resources.Persona);
                }
                else if (AficionadosSeleccionados.First().mostrar_foto)
                {
                    byte[] picture = AficionadosSeleccionados.First().foto;
                    imgs.Images.Add(cont.ToString(), Image.FromStream(new MemoryStream(picture)));
                }
                else
                {
                    imgs.Images.Add(cont.ToString(), ResumenMundialMongo.Properties.Resources.Persona);
                }
                cont++;
            }


            imgs.ImageSize = new Size(64, 76);
            imgs.ColorDepth = ColorDepth.Depth24Bit;
            lstvComentarios.SmallImageList = imgs;

            //Agregar Comentarios
            cont = 0;
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
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //Coneccion con mongoDB
                String connectionstr = "mongodb://localhost";
                MongoClient client = new MongoClient(connectionstr);

                IMongoDatabase DB = client.GetDatabase("ResumenesMundial");

                //Obtiene la coleccion de Comentarios
                var Comentario = DB.GetCollection<ClaseComentario>("Comentario");

                //variable para actualizar Comentario
                var updateDef = Builders<ClaseComentario>.Update.Set(o => o.mensaje, txtComentarioEditar.Text);

                //Actualizar Comentario
                var builder = Builders<ClaseComentario>.Filter;
                var filt = builder.Eq("numero_comentario", Num_Comentario) & builder.Eq("numero_partido", numeroPartidoSeleccionado);
                Comentario.UpdateOne(filt, updateDef);

                MessageBox.Show("Se ha modificado el resumen exitosamente", "Aviso");
                this.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Se produjo un error al modificar el resumen, Error: \n" + er.ToString(), "Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Mensaje de aviso preguntando si realmente desea borrar el comentario
            DialogResult result = MessageBox.Show("¿Realmente desea eliminar el comentario?, Se perdera permanentemente, junto con todas sus respuestas", "Aviso!", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    //Coneccion con mongoDB
                    String connectionstr = "mongodb://localhost";
                    MongoClient client = new MongoClient(connectionstr);

                    IMongoDatabase DB = client.GetDatabase("ResumenesMundial");

                    //Obtiene la coleccion de Comentarios
                    var Comentarios = DB.GetCollection<ClaseComentario>("Comentario");

                    //Borrar Comentarios
                    var builder = Builders<ClaseComentario>.Filter;
                    var filt = builder.Eq("numero_comentario", Num_Comentario) & builder.Eq("numero_partido", numeroPartidoSeleccionado);
                    Comentarios.DeleteOne(filt);

                    MessageBox.Show("Se ha eliminado exitosamente", "Aviso");

                    this.Close();
                }
                catch (Exception er)
                {
                    MessageBox.Show("Se produjo un error al borrar su comentario, Error: \n" + er.ToString(), "Error");
                }
            }
        }
    }
}
