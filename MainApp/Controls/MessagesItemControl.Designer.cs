namespace MainApp.Controls
{
    partial class MessagesItemControl
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
            lbl = new Label();
            userProfileControl1 = new UserProfileControl();
            SuspendLayout();
            // 
            // lbl
            // 
            lbl.Dock = DockStyle.Right;
            lbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl.Location = new Point(76, 0);
            lbl.Name = "lbl";
            lbl.Size = new Size(250, 70);
            lbl.TabIndex = 0;
            lbl.Text = "label1";
            lbl.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // userProfileControl1
            // 
            userProfileControl1.Dock = DockStyle.Left;
            userProfileControl1.Location = new Point(0, 0);
            userProfileControl1.Name = "userProfileControl1";
            userProfileControl1.Size = new Size(70, 70);
            userProfileControl1.TabIndex = 1;
            // 
            // MessagesItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            Controls.Add(userProfileControl1);
            Controls.Add(lbl);
            Name = "MessagesItemControl";
            Size = new Size(326, 70);
            ResumeLayout(false);
        }

        #endregion

        private Label lbl;
        private UserProfileControl userProfileControl1;
    }
}
