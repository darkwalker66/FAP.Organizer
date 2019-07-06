using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAP.Organizer.WinForms
{
    public partial class FullScreenImageForm : Form
    {


        public PictureBox PreviewImage { get
            {
                return this.pictureBoxPreviewImage;
            }
        }

        public MainForm Parent { get; set; }

        public FullScreenImageForm()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            ShowInTaskbar = false;
            this.pictureBoxPreviewImage.SizeMode = PictureBoxSizeMode.Zoom;
            //this.pictureBoxPreviewImage.BackColor = Color.Transparent;
            this.BackColor = Color.LimeGreen;
            this.TransparencyKey = Color.LimeGreen;
        }
        

        private void FullScreenImageForm_Load(object sender, EventArgs e)
        {

        }

        private void FullScreenImageForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Parent != null)
                this.Parent.isPreviewImageOnFullScreen = false;
        }
    }
}
