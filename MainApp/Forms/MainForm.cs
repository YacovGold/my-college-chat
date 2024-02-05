using MainApp.Dal.Entities;
using MainApp.Forms;
using MongoDB.Bson;
using System.Linq;

namespace MainApp
{
    internal partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }
            userProfile1.User = Factory.Instance.State.CurrentUser;
            chatListControl1.ChatSelected += ChatListControl1_ChatSelected;
            chatListControl1.RefreshData();
        }

        private void btn_selectUser_Click(object sender, EventArgs e)
        {
            UsersSelectorForm userSelector = new();
            userSelector.UserSelected += UserSelector_UserSelected;
            userSelector.Location = MousePosition;
            userSelector.Show();

            void UserSelector_UserSelected(object sender, User user)
            {
                var mdal = Factory.Instance.MessagesDal;
                var users = new[] { user.UserId, Factory.Instance.State.CurrentUser.UserId };

                // This should be atomic
                var chats = mdal.ListChats(users).Where(v => v.ChatType == ChatType.User).ToList();
                if (chats.Count > 0)
                {
                    var chat = chats.First();
                    chat.UpdatedAt = DateTime.UtcNow;
                    mdal.UpdateChat(chat);
                    chatListControl1.RefreshData();
                    return;
                }


                var t = new Chat
                {
                    ChatType = ChatType.User,
                    PreviewText = "",
                    Users = users,
                    UpdatedAt = DateTime.UtcNow,
                };
                mdal.CreateChat(t);

                chatListControl1.RefreshData();

                userSelector.UserSelected -= UserSelector_UserSelected;

                ChatListControl1_ChatSelected(this, t);
            }
        }
        private void btn_createGroup_Click(object sender, EventArgs e)
        {
            CreateGroupForm groupCreator = new();
            groupCreator.Location = MousePosition;
            groupCreator.Show();
        }

        private void ChatListControl1_ChatSelected(object sender, Chat chat)
        {
            var udal = Factory.Instance.UsersDal;
            if (chat.ChatType == ChatType.Group)
            {
                var myNick = Factory.Instance.State.CurrentUser.Nick;
                var usersNicks = chat.Users.Select(v => udal.GetUser(v)).Select(v => v.Nick == myNick ? "Me :)" : v.Nick);
                lbl_messagesTitle.Text = $"Group: {string.Join(",", usersNicks)}";
            }
            else
            {
                var suserId = chat.Users.First(v => v != Factory.Instance.State.CurrentUser.UserId);
                var snick = udal.GetUser(suserId).Nick;
                lbl_messagesTitle.Text = $"Your speaking with: {snick}";
            }


            messages1.ChatId = chat.ChatId;
            ActiveControl = tb_msg;
        }

        private void userProfile1_Click(object sender, EventArgs e)
        {
            var epf = new EditProfileForm();
            epf.ShowDialog();
            // Refresh user profile
            userProfile1.User = Factory.Instance.State.CurrentUser;
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            if (messages1.ChatId == ObjectId.Empty)
            {
                MessageBox.Show("Select a chat");
                return;
            }

            Factory.Instance.MessagesDal.CreateMessage(new Dal.Entities.Message
            {
                ChatId = messages1.ChatId,
                CreatedOn = DateTime.UtcNow,
                Text = tb_msg.Text,
                Type = MessageType.Text,
                UserId = Factory.Instance.State.CurrentUser.UserId,
            });
            tb_msg.Text = string.Empty;
            messages1.RefreshData();
            messages1.ScrollDown();
            chatListControl1.RefreshData();
        }
    }
}