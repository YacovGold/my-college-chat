namespace MainApp.Controls
{
    partial class ChatsItemControl
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
            lbl_title = new Label();
            lbl_preview = new Label();
            userProfileControl1 = new UserProfileControl();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_title.Location = new Point(80, 10);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(63, 25);
            lbl_title.TabIndex = 1;
            lbl_title.Text = "Yacov";
            // 
            // lbl_preview
            // 
            lbl_preview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_preview.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_preview.Location = new Point(80, 35);
            lbl_preview.Name = "lbl_preview";
            lbl_preview.Size = new Size(176, 23);
            lbl_preview.TabIndex = 3;
            lbl_preview.Text = "im good, how are...";
            // 
            // userProfileControl1
            // 
            userProfileControl1.Location = new Point(0, 0);
            userProfileControl1.Name = "userProfileControl1";
            userProfileControl1.Size = new Size(70, 70);
            userProfileControl1.TabIndex = 4;
            // 
            // ChatsItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(userProfileControl1);
            Controls.Add(lbl_preview);
            Controls.Add(lbl_title);
            Name = "ChatsItemControl";
            Size = new Size(259, 70);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_title;
        private Label lbl_preview;
        private UserProfileControl userProfileControl1;
    }
}
