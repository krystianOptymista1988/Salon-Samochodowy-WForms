using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Salon_Samochodowy_WF
{
    public partial class PictureView : Form
    {
        public string pictureName;
        public SystemDrawingSection pictureSection;
        public PictureView(string pictureName)
        {
            InitializeComponent();
            PictureShow(pictureName);
        }
        public void PictureShow(string pictureName)
        {
            pbCar.ImageLocation = pictureName;
        }
    }
}
