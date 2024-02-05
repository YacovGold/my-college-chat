namespace MainApp.Controls
{
    partial class UsersSelectorItemControl
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
            lbl_nick = new Label();
            userProfile1 = new UserProfileControl();
            SuspendLayout();
            // 
            // lbl_nick
            // 
            lbl_nick.AutoSize = true;
            lbl_nick.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nick.Location = new Point(80, 10);
            lbl_nick.Name = "lbl_nick";
            lbl_nick.Size = new Size(63, 25);
            lbl_nick.TabIndex = 3;
            lbl_nick.Text = "Yacov";
            // 
            // userProfile1
            // 
            userProfile1.Location = new Point(0, 0);
            userProfile1.Name = "userProfile1";
            userProfile1.Size = new Size(70, 70);
            userProfile1.TabIndex = 4;
            // 
            // UsersSelectorItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(userProfile1);
            Controls.Add(lbl_nick);
            Name = "UsersSelectorItem";
            Size = new Size(436, 70);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_nick;
        private UserProfileControl userProfile1;
    }
}
