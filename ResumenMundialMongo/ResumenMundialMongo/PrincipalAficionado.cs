using ResumenMundialMongo.BD;
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
    public partial class frmPrincipalAficionado : Form
    {
        public frmPrincipalAficionado()
        {
            InitializeComponent();
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

            //Mensaje de aviso preguntando si realmente desea salir
            DialogResult result = MessageBox.Show("¿Realmente desea cambiar la foto?", "Aviso", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                //TODO actualizar BD
            }
            else
            {
                //TODO volver cambiar picturebox
            }
        }

        private void chkbFoto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbFoto.Checked)
            {
                //TODO actualizar BD a true
            }
            else
            {
                //TODO actualizar BD a false
            }
        }

        private void chkbCorreo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbCorreo.Checked)
            {
                //TODO actualizar BD a true
            }
            else
            {
                //TODO actualizar BD a false
            }
        }
        
        private void btnAbrirResumen_Click(object sender, EventArgs e)
        {
          
        }
    }
}
