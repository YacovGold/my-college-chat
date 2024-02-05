namespace MainApp.Forms
{
    partial class UsersSelectorForm
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
            tb_filter = new TextBox();
            usersListControl1 = new Controls.UsersListControl();
            SuspendLayout();
            // 
            // tb_filter
            // 
            tb_filter.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_filter.Location = new Point(0, -1);
            tb_filter.Name = "tb_filter";
            tb_filter.PlaceholderText = "Search Users";
            tb_filter.Size = new Size(300, 23);
            tb_filter.TabIndex = 6;
            tb_filter.TextChanged += tb_filter_TextChanged;
            // 
            // usersListControl1
            // 
            usersListControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usersListControl1.Location = new Point(0, 28);
            usersListControl1.Name = "usersListControl1";
            usersListControl1.Size = new Size(300, 569);
            usersListControl1.TabIndex = 7;
            // 
            // UsersSelectorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(300, 596);
            Controls.Add(usersListControl1);
            Controls.Add(tb_filter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UsersSelectorForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "UsersSelector";
            TopMost = true;
            Deactivate += UsersSelector_Deactivate;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_filter;
        private Controls.UsersListControl usersListControl1;
    }
}