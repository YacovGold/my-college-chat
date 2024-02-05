using MainApp.Controls;

namespace MainApp.Forms
{
    partial class CreateGroupForm
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
            usersListControl1 = new UsersListControl();
            btn_create = new Button();
            tb_groupTitle = new TextBox();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // usersListControl1
            // 
            usersListControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usersListControl1.BackColor = SystemColors.ActiveCaption;
            usersListControl1.Location = new Point(12, 41);
            usersListControl1.Name = "usersListControl1";
            usersListControl1.Size = new Size(276, 480);
            usersListControl1.TabIndex = 0;
            // 
            // btn_create
            // 
            btn_create.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_create.Location = new Point(213, 527);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(75, 23);
            btn_create.TabIndex = 1;
            btn_create.Text = "Ok";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // tb_groupTitle
            // 
            tb_groupTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tb_groupTitle.Location = new Point(12, 12);
            tb_groupTitle.Name = "tb_groupTitle";
            tb_groupTitle.PlaceholderText = "Group Name";
            tb_groupTitle.Size = new Size(276, 23);
            tb_groupTitle.TabIndex = 2;
            // 
            // btn_cancel
            // 
            btn_cancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_cancel.Location = new Point(132, 527);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 3;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += CloseHandler;
            // 
            // CreateGroupForm
            // 
            AcceptButton = btn_create;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_cancel;
            ClientSize = new Size(300, 562);
            Controls.Add(btn_cancel);
            Controls.Add(tb_groupTitle);
            Controls.Add(btn_create);
            Controls.Add(usersListControl1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateGroupForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "UsersSelector";
            TopMost = true;
            Deactivate += CloseHandler;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UsersListControl usersListControl1;
        private Button btn_create;
        private TextBox tb_groupTitle;
        private Button btn_cancel;
    }
}