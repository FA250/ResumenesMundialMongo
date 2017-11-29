using MongoDB.Driver;
using ResumenMundialMongo.BD;
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
    public partial class frmPrincipalAficionado : Form
    {
        ClaseAficionado AficionadoLogeado;
        public frmPrincipalAficionado(ClaseAficionado Aficionado)
        {
            InitializeComponent();
            AficionadoLogeado = Aficionado;
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
                    Aficionados.UpdateOne(o => o.codigo == AficionadoLogeado.codigo, updateDef);

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


        private void btnAbrirResumen_Click(object sender, EventArgs e)
        {
            if (txtSeleccionarResumen.Text.Trim() == "")
            {
                MessageBox.Show("Debe ingresar el número de partido", "Error");
            }
            else
            {
                frmMostrarResumen Resumen = new frmMostrarResumen();
                Resumen.Show();
            }
        }

        private void frmPrincipalAficionado_Load(object sender, EventArgs e)
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

        private void btnBorrarUsuario_Click(object sender, EventArgs e)
        {

            //Mensaje de aviso preguntando si realmente desea borrar la cuenta
            DialogResult result = MessageBox.Show("¿Realmente desea eliminar su cuenta?", "Aviso", MessageBoxButtons.YesNo);

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


                    //variable para actualizar imagen
                    var updateDef = Builders<ClaseAficionado>.Update.Set(o => o.borrado, true);
                    var updateDef1 = Builders<ClaseAficionado>.Update.Set(o => o.fecha_borrado, System.DateTime.Now);

                    //Actualizar Imagen
                    Aficionados.UpdateOne(o => o.codigo == AficionadoLogeado.codigo, updateDef);
                    Aficionados.UpdateOne(o => o.codigo == AficionadoLogeado.codigo, updateDef1);

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