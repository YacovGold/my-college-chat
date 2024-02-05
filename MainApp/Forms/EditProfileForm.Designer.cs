namespace MainApp.Forms
{
    partial class EditProfileForm
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
            userProfileControl1 = new Controls.UserProfileControl();
            label1 = new Label();
            tb_nick = new TextBox();
            btn_cancel = new Button();
            btn_ok = new Button();
            openFileDialog1 = new OpenFileDialog();
            cb_gender = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // userProfileControl1
            // 
            userProfileControl1.Location = new Point(12, 12);
            userProfileControl1.Name = "userProfileControl1";
            userProfileControl1.Size = new Size(100, 100);
            userProfileControl1.TabIndex = 0;
            userProfileControl1.Click += userProfileControl1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(118, 9);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 1;
            label1.Text = "My Nick";
            // 
            // tb_nick
            // 
            tb_nick.Location = new Point(139, 37);
            tb_nick.Name = "tb_nick";
            tb_nick.PlaceholderText = "Nick";
            tb_nick.Size = new Size(121, 23);
            tb_nick.TabIndex = 2;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(278, 164);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(75, 23);
            btn_cancel.TabIndex = 3;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(197, 164);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(75, 23);
            btn_ok.TabIndex = 4;
            btn_ok.Text = "Ok";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
            openFileDialog1.Title = "Select Profile Picture";
            // 
            // cb_gender
            // 
            cb_gender.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_gender.FormattingEnabled = true;
            cb_gender.Items.AddRange(new object[] { "Male", "Female" });
            cb_gender.Location = new Point(139, 91);
            cb_gender.Name = "cb_gender";
            cb_gender.Size = new Size(121, 23);
            cb_gender.TabIndex = 5;
            cb_gender.SelectedIndexChanged += cb_gender_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(118, 63);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 6;
            label2.Text = "Gender";
            // 
            // EditProfileForm
            // 
            AcceptButton = btn_ok;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btn_cancel;
            ClientSize = new Size(365, 199);
            Controls.Add(label2);
            Controls.Add(cb_gender);
            Controls.Add(btn_ok);
            Controls.Add(btn_cancel);
            Controls.Add(tb_nick);
            Controls.Add(label1);
            Controls.Add(userProfileControl1);
            MaximizeBox = false;
            Name = "EditProfileForm";
            Text = "EditProfileForm";
            Load += EditProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Controls.UserProfileControl userProfileControl1;
        private Label label1;
        private TextBox tb_nick;
        private Button btn_cancel;
        private Button btn_ok;
        private OpenFileDialog openFileDialog1;
        private ComboBox cb_gender;
        private Label label2;
    }
}