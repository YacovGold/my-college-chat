using MainApp.Dal.Entities;

namespace MainApp.Controls
{
    public partial class ChatsItemControl : EventBubblerControl
    {
        Chat _chat { get; }

        public ChatsItemControl(Chat chat)
        {
            InitializeComponent();
            _chat = chat;

            lbl_preview.Text = _chat.PreviewText;

            if (_chat.ChatType == ChatType.User)
            {
                var toUserId = _chat.Users.First(v => v != Factory.Instance.State.CurrentUser.UserId);
                var user = Factory.Instance.UsersDal.GetUser(toUserId); // We should use cache...

                lbl_title.Text = user.Nick;
                userProfileControl1.User = user;
            }
            else if (_chat.ChatType == ChatType.Group)
            {
                lbl_title.Text = _chat.GroupTitle;
                userProfileControl1.User = new() { };
            }
        }
    }
}
