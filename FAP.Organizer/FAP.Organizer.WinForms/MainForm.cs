using FAP.Organizer.WinForms.Entities;
using FAP.Organizer.WinForms.Handlers;
using FAP.Organizer.WinForms.Services;
using FAP.Organizer.WPF.Entities;
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

namespace FAP.Organizer.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            listViewImages.SmallImageList = imageListSmall;
            listViewImages.LargeImageList = imageListLarge;            
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            imageList.ColorDepth = ColorDepth.Depth16Bit;
            imageListLarge.ColorDepth = ColorDepth.Depth16Bit;
            imageListSmall.ColorDepth = ColorDepth.Depth16Bit;
            //tags
            this.tagHandler = new TagHandler();
            foreach (var tag in tagHandler.Tags)
            {
                tagListBox.Items.Add(tag.Name);
            }
            
        }




        #region Properties/Members

        public bool isPreviewImageOnFullScreen { get; set; }
        FullScreenImageForm fullScreenImageForm;
        TagHandler tagHandler;

        OpenFileDialog ofd = new OpenFileDialog()
        {
            Multiselect = true,
            ValidateNames = true,
            Filter = "JPG|*jpg|JPEG|*.jpeg|PNG|*.png"
        };
        ImageList imageList = new ImageList();        
        List<string> _imgs = new List<string>();
        ImageList imageListSmall= new ImageList();
        ImageList imageListLarge = new ImageList();
        int imageCount = 0; //image index for ListView
        int currentImageSelectedIndex = 0;
        FileInfo fi;
        bool slideShowRandom = false;
        List<ImageResource> loadedImages = new List<ImageResource>();
        #endregion

        private void BtnSearchImages_Click(object sender, EventArgs e)
        {
            //setup imagelist sizes
            //imageList.ImageSize = new Size(50, 50);
            imageListSmall.ImageSize = new Size(32, 32);
            imageListLarge.ImageSize = new Size(80, 80);

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                
                listViewImages.Items.Clear();
                foreach (string fileName in ofd.FileNames)
                {
                    fi = new FileInfo(fileName);                               
                    using (FileStream stream = new FileStream(fi.FullName, FileMode.Open, FileAccess.Read))
                    {
                        Image img = Image.FromStream(stream);
                        var imgResource = new ImageResource(fileName, stream);
                        loadedImages.Add(imgResource);

                        _imgs.Add(fileName);                        
                        imageList.Images.Add(img);
                        imageListSmall.Images.Add(img);
                        imageListLarge.Images.Add(img);
                    }

                    listViewImages.LargeImageList = imageListLarge;
                    listViewImages.Items.Add(new ListViewItem()
                    {
                        ImageIndex = imageCount,
                        Text = fi.Name,
                        Tag = fi.Name
                    });
                    imageCount++;
                }
                
            }
        }


        private void RbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmallIcon.Checked)
            {
                listViewImages.View = View.SmallIcon;
            }
        }

        private void RbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLargeIcon.Checked)
            {
                listViewImages.LargeImageList = imageListLarge;
                listViewImages.View = View.LargeIcon;
            }
        }

        private void RbTiles_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTiles.Checked)
            {
                listViewImages.View = View.Tile;
            }
        }

        private void ListViewImages_Click(object sender, EventArgs e)
        {
            var firstSelectedItem = listViewImages.SelectedItems[0];
            //pictureBox1.Image = imageList.Images[firstSelectedItem.ImageIndex];
            //pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            string fileName = _imgs[firstSelectedItem.ImageIndex];
            currentImageSelectedIndex = firstSelectedItem.ImageIndex;
            using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                pictureBox1.Image = Image.FromStream(stream);
            }

        }

        private void SlideShowTimer_Tick(object sender, EventArgs e)
        {
            string fileName = "";
            if (slideShowRandom)
            {
                var rand = new Random();
                var randomIndex = rand.Next(_imgs.Count);
                if (_imgs.Count > 0)
                    fileName = _imgs[randomIndex];

            }
            else
            {
                if (_imgs.Count > 0)
                    fileName = _imgs[currentImageSelectedIndex];
            }
            if (!string.IsNullOrWhiteSpace(fileName))
            {
                using (FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = Image.FromStream(stream);
                    //update image on fullscreen mode
                    if (this.isPreviewImageOnFullScreen)
                    {
                        fullScreenImageForm.PreviewImage.Image = this.pictureBox1.Image;
                    }
                }
                currentImageSelectedIndex++;
                if (currentImageSelectedIndex >= _imgs.Count)
                    currentImageSelectedIndex = 0;
            }
            
        }

        private void BtnSlide_Click(object sender, EventArgs e)
        {
            if (slideShowTimer.Enabled)
                slideShowTimer.Stop();
            else
                slideShowTimer.Start();
        }

        private void SlideShowTimerNumeric_ValueChanged(object sender, EventArgs e)
        {
            this.slideShowTimer.Interval = ((int)SlideShowTimerNumeric.Value) * 1000;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            tagHandler.SaveTagsToDisk();
            ResourceManagerService.SaveImagesInfoToDisk(loadedImages, "C:\\loadedImages.txt");
            
        }

        private void CheckRandom_CheckedChanged(object sender, EventArgs e)
        {
            slideShowRandom = checkRandom.Checked;
        }

        private void BtnClearList_Click(object sender, EventArgs e)
        {
            currentImageSelectedIndex = 0;
            imageCount = 0;
            _imgs.Clear();
            imageList.Images.Clear();
            imageListLarge.Images.Clear();
            imageListSmall.Images.Clear();
        }

        /// <summary>
        /// Opens a new form and displays it with the current selected image on fullscreen
        /// and transparent background.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PictureBox1_DoubleClick(object sender, EventArgs e)
        {
            fullScreenImageForm = new FullScreenImageForm();
            fullScreenImageForm.Parent = this;
            fullScreenImageForm.PreviewImage.Image = this.pictureBox1.Image;
            this.isPreviewImageOnFullScreen = true; // used to change images on fullscreen slide show
            fullScreenImageForm.Show();
        }
    }
}
