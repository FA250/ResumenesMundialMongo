using MongoDB.Bson;
using MongoDB.Driver;
using ResumenMundialMongo.BD;
using ResumenMundialMongo.Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
        String TextoPathVideos = "";
        List<String> PathVideos = new List<String>();

        private void btnAgregarVideo_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Media Files|*.mpg;*.avi;*.wma;*.mov;*.wav;*.mp2;*.mp3|All Files|*.*";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // image file path  
                String PathV = open.FileName;
                TextoPathVideos += PathV + ",";
                PathVideos.Add(PathV);
            }
            lblVideos.Text = TextoPathVideos;
        }

        private void btnAbrirResumen_Click(object sender, EventArgs e)
        {
            if (txtSeleccionarResumen.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el número de partido", "Error");
            }
            else
            {
                //Coneccion con mongoDB
                String connectionstr = "mongodb://localhost";
                MongoClient client = new MongoClient(connectionstr);

                IMongoDatabase DB = client.GetDatabase("ResumenesMundial");

                //Obtiene la coleccion de Afincionados
                var ResumenP = DB.GetCollection<ClaseResumen>("ResumenPartido");

                var ResumenEncontrado = ResumenP.AsQueryable().Where(resumen => resumen.numero_partido == txtSeleccionarResumen.Text);
                int CantEncontrada = ResumenEncontrado.Count();

                if (CantEncontrada == 0)
                {
                    MessageBox.Show("El partido ingresado no tiene ningún resumen", "Error");
                }
                else
                {
                    frmMostrarResumen Resumen = new frmMostrarResumen(ResumenEncontrado.First(),true);
                    Resumen.Show();
                }
            }
        }

        public static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        private void btnResumen_Click(object sender, EventArgs e)
        {
           if (txtRegistroResumen.Text.Trim() == "")
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
                    if (Partido[0].ToString() == txtRegistroResumen.Text)
                    {
                        PartidoExiste = true;
                    }
                }
                if (PartidoExiste)
                {
                    //Coneccion con mongoDB
                    String connectionstr = "mongodb://localhost";
                    MongoClient client = new MongoClient(connectionstr);

                    IMongoDatabase DB = client.GetDatabase("ResumenesMundial");

                    //Obtiene la coleccion de Resumenes de Partido
                    var ResumenesPartidos = DB.GetCollection<ClaseResumen>("ResumenPartido");

                    var ResumenEncontrado = ResumenesPartidos.AsQueryable().Where(resumen => resumen.numero_partido == txtRegistroResumen.Text);
                    int CantEncontrada = ResumenEncontrado.Count();

                     if (CantEncontrada >= 1)
                    {
                        MessageBox.Show("Ya existe un resumen con el partido " + txtRegistroResumen.Text, "Error");
                    }
                    if(txtRegistroResumen.Text.Trim()=="")
                    {
                        MessageBox.Show("Debe escribir el numero del partido", "Error");
                    }
                    else if (txtTextoResumen.Text.Trim() == "")
                    {
                        MessageBox.Show("Debe escribir el resumen del partido", "Error");
                    }
                    else
                    {                  
                        List<byte[]> Videos=new List<byte[]>();
                        foreach(String Video in PathVideos){
                            Stream video = File.OpenRead(Video);
                            Videos.Add(ReadFully(video));
                        }

                        BsonArray VideosBson = new BsonArray { };

                        int cont=1;
                        foreach (byte[] V in Videos)
                        {
                            VideosBson.Add(new BsonDocument { { "codigoV", cont }, { "video", new BsonBinaryData ( V ) } });
                            cont++;
                        }

                        //Crea documento de Bson para insertar la coleccion en la BD
                        BsonDocument NuevoResumen = new BsonDocument
                        {
                            { "numero_partido" , txtRegistroResumen.Text},
                            { "mensaje", txtTextoResumen.Text},
                            { "equipos", lblEquipos.Text },
                            { "videos", VideosBson},
                        
                        };



                        IMongoCollection<BsonDocument> Resumen = DB.GetCollection<BsonDocument>("ResumenPartido");
                        Resumen.InsertOne(NuevoResumen);

                        MessageBox.Show("Se ha insertado correctamente el resumen", "Aviso");
                    }                    
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

        private void btnCambiarFoto_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pctbImagenPerfil.Image = new Bitmap(open.FileName);
            }

            //Mensaje de aviso preguntando si realmente desea cambiar la foto
            DialogResult result = MessageBox.Show("¿Realmente desea cambiar la foto?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                try
                {
                    //Coneccion con mongoDB
                    String connectionstr = "mongodb://localhost";
                    MongoClient client = new MongoClient(connectionstr);

                    IMongoDatabase DB = client.GetDatabase("ResumenesMundial");

                    //Obtiene la coleccion de Afincionados
                    var Aficionados = DB.GetCollection<ClaseAficionado>("Aficionado");

                    //Convertir imagen de picture box en datos binarios para poderlo insertar en la BD
                    MemoryStream ms = new MemoryStream();
                    pctbImagenPerfil.Image.Save(ms, ImageFormat.Png);
                    byte[] imgData = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(imgData, 0, imgData.Length);
                       
                    //variable para actualizar imagen
                    var updateDef = Builders<ClaseAficionado>.Update.Set(o => o.foto, imgData);

                    //Actualizar Imagen
                    Aficionados.UpdateOne(o=> o.codigo == AficionadoLogeado.codigo, updateDef);

                    AficionadoLogeado.foto = imgData;

                    MessageBox.Show("Se ha actualizado la imagen exitosamente", "Aviso");
                }
                catch (Exception er)
                {
                    MessageBox.Show("Se produjo un error al actualizar la imagen, Error: \n" + er.ToString(), "Error");
                }
            }
            else
            {
                //Mostrar imagen guardada
                byte[] picture = AficionadoLogeado.foto;
                pctbImagenPerfil.Image = Image.FromStream(new MemoryStream(picture));
                pctbImagenPerfil.Refresh();
            }
        }

        private void chkbFoto_Click(object sender, EventArgs e)
        {
            //Coneccion con mongoDB
            String connectionstr = "mongodb://localhost";
            MongoClient client = new MongoClient(connectionstr);

            IMongoDatabase DB = client.GetDatabase("ResumenesMundial");

            //Obtiene la coleccion de Afincionados
            var Aficionados = DB.GetCollection<ClaseAficionado>("Aficionado");

            if (chkbFoto.Checked)
            {
                try
                {
                    //variable para actualizar
                    var updateDef = Builders<ClaseAficionado>.Update.Set(o => o.mostrar_foto, true);

                    //Actualizar Valor
                    Aficionados.UpdateOne(o => o.codigo == AficionadoLogeado.codigo, updateDef);

                    AficionadoLogeado.mostrar_foto = true;

                    MessageBox.Show("Se ha realizado la modificación exitosamente", "Aviso");
                }
                catch (Exception er)
                {
                    MessageBox.Show("Se produjo un error al modificar el valor, Error" + er.ToString(), "Error");
                }
            }
            else
            {
                try
                {
                    //variable para actualizar
                    var updateDef = Builders<ClaseAficionado>.Update.Set(o => o.mostrar_foto, false);

                    //Actualizar Valor
                    Aficionados.UpdateOne(o => o.codigo == AficionadoLogeado.codigo, updateDef);

                    AficionadoLogeado.mostrar_foto = false;

                    MessageBox.Show("Se ha realizado la modificación exitosamente", "Aviso");
                }
                catch (Exception er)
                {
                    MessageBox.Show("Se produjo un error al modificar el valor, Error" + er.ToString(), "Error");
                }
            }
        }

        private void chkbCorreo_Click(object sender, EventArgs e)
        {
            //Coneccion con mongoDB
            String connectionstr = "mongodb://localhost";
            MongoClient client = new MongoClient(connectionstr);

            IMongoDatabase DB = client.GetDatabase("ResumenesMundial");

            //Obtiene la coleccion de Afincionados
            var Aficionados = DB.GetCollection<ClaseAficionado>("Aficionado");
            if (chkbCorreo.Checked)
            {
                try
                {
                    //variable para actualizar
                    var updateDef = Builders<ClaseAficionado>.Update.Set(o => o.mostrar_correo, true);

                    //Actualizar Valor
                    Aficionados.UpdateOne(o => o.codigo == AficionadoLogeado.codigo, updateDef);

                    AficionadoLogeado.mostrar_correo = true;

                    MessageBox.Show("Se ha realizado la modificación exitosamente", "Aviso");
                }
                catch (Exception er)
                {
                    MessageBox.Show("Se produjo un error al modificar el valor, Error" + er.ToString(), "Error");
                }
            }
            else
            {
                try
                {
                    //variable para actualizar
                    var updateDef = Builders<ClaseAficionado>.Update.Set(o => o.mostrar_correo, false);

                    //Actualizar Valor
                    Aficionados.UpdateOne(o => o.codigo == AficionadoLogeado.codigo, updateDef);

                    AficionadoLogeado.mostrar_correo = false;

                    MessageBox.Show("Se ha realizado la modificación exitosamente", "Aviso");
                }
                catch (Exception er)
                {
                    MessageBox.Show("Se produjo un error al modificar el valor, Error" + er.ToString(), "Error");
                }
            }
        }

        private void txtRegistroResumen_Leave(object sender, EventArgs e)
        {
            ClaseMD MD = new ClaseMD();
            ArrayList Partidos = MD.Select_Todos_Partidos();
            ArrayList Partido = new ArrayList();
            bool PartidoExiste = false;
            foreach (ArrayList Pt in Partidos)
            {
                if (Pt[0].ToString() == txtRegistroResumen.Text)
                {
                    Partido = Pt;
                    PartidoExiste = true;
                }
            }
            if (PartidoExiste)
            {
                lblEquipos.Text = Partido[1] + " - " + Partido[2];
            }
            else
            {
                MessageBox.Show("El partido ingresado no existe", "Error");
            }
        }                
    }
}
