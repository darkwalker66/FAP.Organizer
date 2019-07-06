using System;
using System.Drawing;
using System.Windows.Forms;

namespace FAP.Organizer.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSearchImages = new System.Windows.Forms.Button();
            this.rbSmallIcon = new System.Windows.Forms.RadioButton();
            this.rbLargeIcon = new System.Windows.Forms.RadioButton();
            this.rbTiles = new System.Windows.Forms.RadioButton();
            this.btnClearList = new System.Windows.Forms.Button();
            this.listViewImages = new System.Windows.Forms.ListView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSlide = new System.Windows.Forms.Button();
            this.SlideShowTimerNumeric = new System.Windows.Forms.NumericUpDown();
            this.checkRandom = new System.Windows.Forms.CheckBox();
            this.slideShowTimer = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlideShowTimerNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listViewImages, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.77778F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.22222F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(674, 299);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.DoubleClick += new System.EventHandler(this.PictureBox1_DoubleClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnSearchImages);
            this.flowLayoutPanel1.Controls.Add(this.rbSmallIcon);
            this.flowLayoutPanel1.Controls.Add(this.rbLargeIcon);
            this.flowLayoutPanel1.Controls.Add(this.rbTiles);
            this.flowLayoutPanel1.Controls.Add(this.btnClearList);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(683, 308);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(114, 139);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btnSearchImages
            // 
            this.btnSearchImages.Location = new System.Drawing.Point(3, 3);
            this.btnSearchImages.Name = "btnSearchImages";
            this.btnSearchImages.Size = new System.Drawing.Size(102, 23);
            this.btnSearchImages.TabIndex = 0;
            this.btnSearchImages.Text = "Open";
            this.btnSearchImages.UseVisualStyleBackColor = true;
            this.btnSearchImages.Click += new System.EventHandler(this.BtnSearchImages_Click);
            // 
            // rbSmallIcon
            // 
            this.rbSmallIcon.AutoSize = true;
            this.rbSmallIcon.Location = new System.Drawing.Point(3, 32);
            this.rbSmallIcon.Name = "rbSmallIcon";
            this.rbSmallIcon.Size = new System.Drawing.Size(79, 17);
            this.rbSmallIcon.TabIndex = 1;
            this.rbSmallIcon.TabStop = true;
            this.rbSmallIcon.Text = "Small Icons";
            this.rbSmallIcon.UseVisualStyleBackColor = true;
            this.rbSmallIcon.CheckedChanged += new System.EventHandler(this.RbSmallIcon_CheckedChanged);
            // 
            // rbLargeIcon
            // 
            this.rbLargeIcon.AutoSize = true;
            this.rbLargeIcon.Location = new System.Drawing.Point(3, 55);
            this.rbLargeIcon.Name = "rbLargeIcon";
            this.rbLargeIcon.Size = new System.Drawing.Size(81, 17);
            this.rbLargeIcon.TabIndex = 2;
            this.rbLargeIcon.TabStop = true;
            this.rbLargeIcon.Text = "Large Icons";
            this.rbLargeIcon.UseVisualStyleBackColor = true;
            this.rbLargeIcon.CheckedChanged += new System.EventHandler(this.RbLargeIcon_CheckedChanged);
            // 
            // rbTiles
            // 
            this.rbTiles.AutoSize = true;
            this.rbTiles.Location = new System.Drawing.Point(3, 78);
            this.rbTiles.Name = "rbTiles";
            this.rbTiles.Size = new System.Drawing.Size(47, 17);
            this.rbTiles.TabIndex = 3;
            this.rbTiles.TabStop = true;
            this.rbTiles.Text = "Tiles";
            this.rbTiles.UseVisualStyleBackColor = true;
            this.rbTiles.CheckedChanged += new System.EventHandler(this.RbTiles_CheckedChanged);
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(3, 101);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(102, 23);
            this.btnClearList.TabIndex = 4;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.BtnClearList_Click);
            // 
            // listViewImages
            // 
            this.listViewImages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewImages.Location = new System.Drawing.Point(3, 308);
            this.listViewImages.Name = "listViewImages";
            this.listViewImages.Size = new System.Drawing.Size(674, 139);
            this.listViewImages.TabIndex = 2;
            this.listViewImages.UseCompatibleStateImageBehavior = false;
            this.listViewImages.Click += new System.EventHandler(this.ListViewImages_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnSave);
            this.flowLayoutPanel2.Controls.Add(this.btnSlide);
            this.flowLayoutPanel2.Controls.Add(this.SlideShowTimerNumeric);
            this.flowLayoutPanel2.Controls.Add(this.checkRandom);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(683, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(114, 299);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.Location = new System.Drawing.Point(3, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnSlide
            // 
            this.btnSlide.Location = new System.Drawing.Point(3, 32);
            this.btnSlide.Name = "btnSlide";
            this.btnSlide.Size = new System.Drawing.Size(102, 23);
            this.btnSlide.TabIndex = 1;
            this.btnSlide.Text = "Slide Show";
            this.btnSlide.UseVisualStyleBackColor = true;
            this.btnSlide.Click += new System.EventHandler(this.BtnSlide_Click);
            // 
            // SlideShowTimerNumeric
            // 
            this.SlideShowTimerNumeric.Location = new System.Drawing.Point(3, 61);
            this.SlideShowTimerNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SlideShowTimerNumeric.Name = "SlideShowTimerNumeric";
            this.SlideShowTimerNumeric.Size = new System.Drawing.Size(66, 20);
            this.SlideShowTimerNumeric.TabIndex = 2;
            this.SlideShowTimerNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SlideShowTimerNumeric.ValueChanged += new System.EventHandler(this.SlideShowTimerNumeric_ValueChanged);
            // 
            // checkRandom
            // 
            this.checkRandom.AutoSize = true;
            this.checkRandom.Location = new System.Drawing.Point(3, 87);
            this.checkRandom.Name = "checkRandom";
            this.checkRandom.Size = new System.Drawing.Size(66, 17);
            this.checkRandom.TabIndex = 3;
            this.checkRandom.Text = "Random";
            this.checkRandom.UseVisualStyleBackColor = true;
            this.checkRandom.CheckedChanged += new System.EventHandler(this.CheckRandom_CheckedChanged);
            // 
            // slideShowTimer
            // 
            this.slideShowTimer.Interval = 1300;
            this.slideShowTimer.Tick += new System.EventHandler(this.SlideShowTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Organizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SlideShowTimerNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
            //string imagePath = Path.Combine("Resource", "TestImages", "file.jpg");
            Image image = FAP.Organizer.WinForms.Properties.Resources.workingOn;
            pictureBox1.Image = image;
            pictureBox1.Height = image.Height;
            pictureBox1.Width = image.Width;

        }
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnSearchImages;
        private ListView listViewImages;
        private RadioButton rbSmallIcon;
        private RadioButton rbLargeIcon;
        private RadioButton rbTiles;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnSave;
        private Button btnSlide;
        private Timer slideShowTimer;
        private NumericUpDown SlideShowTimerNumeric;
        private CheckBox checkRandom;
        private Button btnClearList;
    }
}

