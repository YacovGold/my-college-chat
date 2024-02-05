namespace MainApp.Controls
{
    partial class UserProfileControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pb_figure = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb_figure).BeginInit();
            SuspendLayout();
            // 
            // pb_figure
            // 
            pb_figure.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pb_figure.BackgroundImageLayout = ImageLayout.Stretch;
            pb_figure.Image = Properties.Resources.ManFigure;
            pb_figure.Location = new Point(0, 0);
            pb_figure.Name = "pb_figure";
            pb_figure.Size = new Size(100, 100);
            pb_figure.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_figure.TabIndex = 4;
            pb_figure.TabStop = false;
            // 
            // UserProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pb_figure);
            Name = "UserProfile";
            Size = new Size(100, 100);
            ((System.ComponentModel.ISupportInitialize)pb_figure).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pb_figure;
    }
}
