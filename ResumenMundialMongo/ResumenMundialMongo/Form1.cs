using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using MongoDB.Bson;
using System.IO;
using System.Drawing.Imaging;

namespace ResumenMundialMongo
{
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }

        private void btnElegirFoto_Click(object sender, EventArgs e)
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
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Coneccion con mongoDB
            String connectionstr = "mongodb://localhost";
            MongoClient client = new MongoClient(connectionstr);

            IMongoDatabase DB = client.GetDatabase("ResumenesMundial");

            //Obtiene la coleccion de Afincionados
            var Aficionados = DB.GetCollection<ClaseAficionado>("Aficionado");

            if (txtIngresoCod.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el código del aficionado", "Error");
            }
            else if (txtIngresoContrasena.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la contraseña", "Error");
            }
            else
            {
                var AficionadoEncontrado = Aficionados.AsQueryable().Where(aficionado => aficionado.codigo == txtIngresoCod.Text);
                int CantEncontrada = AficionadoEncontrado.Count();
                
                //Instancia clase para desencriptar contrasena
                ClaseEncriptacion EC = new ClaseEncriptacion();

                if (CantEncontrada == 0)
                {
                    MessageBox.Show("No existe el aficionado con el codigo " + txtIngresoCod.Text, "Error");
                }
                else if (AficionadoEncontrado.First().borrado)
                {
                    MessageBox.Show("El aficionado con el codigo " + txtIngresoCod.Text + " fue borrado", "Error");
                }
                else if (EC.DecryptKey(AficionadoEncontrado.First().contrasena) != txtIngresoContrasena.Text)
                {
                    MessageBox.Show("La contraseña ingresada es incorrecta", "Error");
                }
                else
                {
                    if (txtIngresoCod.Text == "Administrador")
                    {
                        frmPrincipalAdmin Principal = new frmPrincipalAdmin(AficionadoEncontrado.First());
                        Principal.Show();
                    }
                    else
                    {
                        frmPrincipalAficionado Principal = new frmPrincipalAficionado(AficionadoEncontrado.First());
                        Principal.Show();
                    }
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Coneccion con mongoDB
            String connectionstr = "mongodb://localhost";
            MongoClient client = new MongoClient(connectionstr);

            IMongoDatabase DB = client.GetDatabase("ResumenesMundial");

            //Obtiene la coleccion de Afincionados
            var Aficionados = DB.GetCollection<ClaseAficionado>("Aficionado");

            if (txtRegistroCod.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el código del aficionado", "Error");
            }
            else if (txtRegistroContrasena.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la contraseña", "Error");
            }
            else if (txtRegistroCorreo.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar la contraseña", "Error");
            }
            else 
            {
                var AficionadoEncontrado = Aficionados.AsQueryable().Where(aficionado => aficionado.codigo == txtRegistroCod.Text);
                int CantEncontrada = AficionadoEncontrado.Count();

                if (CantEncontrada >= 1)
                {
                    MessageBox.Show("Ya existe un aficionado con el codigo " + txtRegistroCod.Text, "Error");
                }
                else
                {
                    //Convertir imagen de picture box en datos binarios para poderlo insertar en la BD
                    MemoryStream ms = new MemoryStream();
                    pctbImagenPerfil.Image.Save(ms, ImageFormat.Png);
                    byte[] imgData = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(imgData, 0, imgData.Length);

                    //Instancia clase para encriptar contrasena
                    ClaseEncriptacion EC = new ClaseEncriptacion();

                    //Crea documento de Bson para insertar la coleccion en la BD
                    BsonDocument DCAficionado = new BsonDocument
                    {
                        { "codigo" , txtRegistroCod.Text},
                        { "contrasena", EC.EncryptKey(txtRegistroContrasena.Text).ToString()},
                        { "foto", new BsonBinaryData(imgData) },
                        { "mostrar_foto", new BsonBoolean(true) },
                        { "correo_electronico", txtRegistroCorreo.Text },
                        { "mostrar_correo", new BsonBoolean(true) },
                        { "borrado", new BsonBoolean(false) },
                        { "fecha_borrado", new DateTime(1, 1, 1, 0, 0, 0, DateTimeKind.Utc) }
                    };

                    IMongoCollection<BsonDocument> Aficionado = DB.GetCollection<BsonDocument>("Aficionado");
                    Aficionado.InsertOne(DCAficionado);

                    MessageBox.Show("Se ha registrado correctamente el aficionado", "Aviso");
                }
            }
        }

        private void frmIngreso_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Mensaje de aviso preguntando si realmente desea salir
            DialogResult result = MessageBox.Show("¿Realmente desea salir?, Se cerraran las demás ventanas abiertas de la aplicación", "Aviso!", MessageBoxButtons.YesNo);

            if (result == DialogResult.No)
            {
                e.Cancel=true;
            }
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            //get current folderpath of the .exe
            string ProgramPath = AppDomain.CurrentDomain.BaseDirectory;
            //jump back relative to the .exe-Path to the Resources Path
            string FileName = string.Format("{0}Resources\\manual_de_usuario_resumen_de_los_partidos.pdf", Path.GetFullPath(Path.Combine(ProgramPath, @"..\..\")));

            //Open PDF
            System.Diagnostics.Process.Start(@"" + FileName + "");
        }
    }
}