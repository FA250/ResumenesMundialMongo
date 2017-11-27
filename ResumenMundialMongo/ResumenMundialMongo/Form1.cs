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
            if (txtIngresoCod.Text == "Administrador")
            {
                frmPrincipalAdmin Principal = new frmPrincipalAdmin();
                Principal.Show();
            }
            else
            {
                frmPrincipalAficionado Principal = new frmPrincipalAficionado();
                Principal.Show();
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
                    MessageBox.Show("Se ha insertado correctamente el aficionado", "Aviso");
                }
            }
        }
    }
}