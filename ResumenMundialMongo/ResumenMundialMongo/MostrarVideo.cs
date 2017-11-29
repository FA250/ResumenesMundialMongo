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
    public partial class frmMostrarVideo : Form
    {
        string strTempFile = "";
        public frmMostrarVideo(byte[] VideoSeleccionado)
        {
            InitializeComponent();
            strTempFile = Path.GetTempPath() + "VideoTemporal.wmv";
            File.WriteAllBytes(strTempFile, VideoSeleccionado);
            Video.URL = strTempFile;
            Video.settings.autoStart = true;
        }

    }
}
