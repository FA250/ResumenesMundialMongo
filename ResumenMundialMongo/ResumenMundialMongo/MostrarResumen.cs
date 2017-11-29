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
    public partial class frmMostrarResumen : Form
    {
        ClaseResumen ResumenSeleccionado = new ClaseResumen();
        public frmMostrarResumen(ClaseResumen Resumen)
        {
            InitializeComponent();
            ResumenSeleccionado = Resumen;
        }

        private void btnComentarios_Click(object sender, EventArgs e)
        {

        }

        private void frmMostrarResumen_Load(object sender, EventArgs e)
        {

        }
    }
}
