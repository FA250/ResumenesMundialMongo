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
    public partial class frmModificarResumen : Form
    {
        String Resumen="";
        String NumPartido;
        public frmModificarResumen(String MensajeResumen, String NumeroDePartido)
        {
            InitializeComponent();
            Resumen = MensajeResumen;
            NumPartido = NumeroDePartido;
        }

        private void frmModificarResumen_Load(object sender, EventArgs e)
        {
            txtTextoResumen.Text = Resumen;
        }

        private void btnModificarResumen_Click(object sender, EventArgs e)
        {
            try
            {
                //Coneccion con mongoDB
                String connectionstr = "mongodb://localhost";
                MongoClient client = new MongoClient(connectionstr);

                IMongoDatabase DB = client.GetDatabase("ResumenesMundial");

                //Obtiene la coleccion de Afincionados
                var ResumenPartido = DB.GetCollection<ClaseResumen>("ResumenPartido");
                                
                //variable para actualizar imagen
                var updateDef = Builders<ClaseResumen>.Update.Set(o => o.mensaje, txtTextoResumen.Text);

                //Actualizar Imagen
                ResumenPartido.UpdateOne(o => o.numero_partido == NumPartido, updateDef);
                
                MessageBox.Show("Se ha modificado el resumen exitosamente", "Aviso");
                this.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("Se produjo un error al modificar el resumen, Error: \n" + er.ToString(), "Error");
            }
        }
    }
}
