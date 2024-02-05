namespace MainApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            messages1 = new Controls.MessagesControl();
            btn_selectUser = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panel1 = new Panel();
            btn_createGroup = new FontAwesome.Sharp.IconButton();
            chatListControl1 = new Controls.ChatsListControl();
            panel2 = new Panel();
            userProfile1 = new Controls.UserProfileControl();
            tb_msg = new TextBox();
            btn_send = new Button();
            lbl_messagesTitle = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // messages1
            // 
            messages1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            messages1.BackColor = SystemColors.ActiveCaption;
            messages1.ChatId = (MongoDB.Bson.ObjectId)resources.GetObject("messages1.ChatId");
            messages1.Location = new Point(290, 40);
            messages1.Name = "messages1";
            messages1.Size = new Size(676, 510);
            messages1.TabIndex = 1;
            // 
            // btn_selectUser
            // 
            btn_selectUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_selectUser.IconChar = FontAwesome.Sharp.IconChar.Pen;
            btn_selectUser.IconColor = Color.Black;
            btn_selectUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_selectUser.IconSize = 40;
            btn_selectUser.Location = new Point(186, 0);
            btn_selectUser.Name = "btn_selectUser";
            btn_selectUser.Size = new Size(40, 40);
            btn_selectUser.TabIndex = 2;
            btn_selectUser.UseVisualStyleBackColor = true;
            btn_selectUser.Click += btn_selectUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 5);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 3;
            label1.Text = "Chats";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(btn_createGroup);
            panel1.Controls.Add(chatListControl1);
            panel1.Controls.Add(btn_selectUser);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(58, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 567);
            panel1.TabIndex = 4;
            // 
            // btn_createGroup
            // 
            btn_createGroup.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_createGroup.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            btn_createGroup.IconColor = Color.Black;
            btn_createGroup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btn_createGroup.IconSize = 40;
            btn_createGroup.Location = new Point(140, 0);
            btn_createGroup.Name = "btn_createGroup";
            btn_createGroup.Size = new Size(40, 40);
            btn_createGroup.TabIndex = 8;
            btn_createGroup.UseVisualStyleBackColor = true;
            btn_createGroup.Click += btn_createGroup_Click;
            // 
            // chatListControl1
            // 
            chatListControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chatListControl1.BackColor = Color.RosyBrown;
            chatListControl1.Location = new Point(0, 46);
            chatListControl1.Name = "chatListControl1";
            chatListControl1.Size = new Size(226, 521);
            chatListControl1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(userProfile1);
            panel2.Location = new Point(12, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(40, 567);
            panel2.TabIndex = 5;
            // 
            // userProfile1
            // 
            userProfile1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userProfile1.Location = new Point(0, 527);
            userProfile1.Name = "userProfile1";
            userProfile1.Size = new Size(40, 40);
            userProfile1.TabIndex = 0;
            userProfile1.Click += userProfile1_Click;
            // 
            // tb_msg
            // 
            tb_msg.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_msg.Location = new Point(290, 556);
            tb_msg.Name = "tb_msg";
            tb_msg.Size = new Size(595, 23);
            tb_msg.TabIndex = 6;
            // 
            // btn_send
            // 
            btn_send.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_send.Location = new Point(891, 556);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(75, 23);
            btn_send.TabIndex = 7;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // lbl_messagesTitle
            // 
            lbl_messagesTitle.AutoSize = true;
            lbl_messagesTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_messagesTitle.Location = new Point(290, 12);
            lbl_messagesTitle.Name = "lbl_messagesTitle";
            lbl_messagesTitle.Size = new Size(130, 25);
            lbl_messagesTitle.TabIndex = 8;
            lbl_messagesTitle.Text = "Select a chat...";
            // 
            // MainForm
            // 
            AcceptButton = btn_send;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 591);
            Controls.Add(lbl_messagesTitle);
            Controls.Add(btn_send);
            Controls.Add(tb_msg);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(messages1);
            Name = "MainForm";
            Text = "MyCollegeChat";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.MessagesControl messages1;
        private FontAwesome.Sharp.IconButton btn_selectUser;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Controls.UserProfileControl userProfile1;
        private Controls.ChatsListControl chatListControl1;
        private TextBox tb_msg;
        private Button btn_send;
        private FontAwesome.Sharp.IconButton btn_createGroup;
        private Label lbl_messagesTitle;
    }
}