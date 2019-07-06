namespace FAP.Organizer.WinForms
{
    partial class FullScreenImageForm
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
            this.pictureBoxPreviewImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviewImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPreviewImage
            // 
            this.pictureBoxPreviewImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxPreviewImage.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPreviewImage.Name = "pictureBoxPreviewImage";
            this.pictureBoxPreviewImage.Size = new System.Drawing.Size(800, 450);
            this.pictureBoxPreviewImage.TabIndex = 0;
            this.pictureBoxPreviewImage.TabStop = false;
            // 
            // FullScreenImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxPreviewImage);
            this.Name = "FullScreenImageForm";
            this.Text = "FullScreenImageForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FullScreenImageForm_FormClosing);
            this.Load += new System.EventHandler(this.FullScreenImageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviewImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPreviewImage;
    }
}