using Message = MainApp.Dal.Entities.Message;

namespace MainApp.Controls
{
    public partial class MessagesItemControl : UserControl
    {
        Message _message;

        public Message Message
        {
            get => _message;
            set
            {
                _message = value;
                lbl.Text = _message.Text;
                userProfileControl1.User = Factory.Instance.UsersDal.GetUser(_message.UserId);

                var isMe = Factory.Instance.State.CurrentUser.UserId == _message.UserId;
                lbl.Dock = isMe ? DockStyle.Left : DockStyle.Right;
                userProfileControl1.Dock = isMe ? DockStyle.Right : DockStyle.Left;
                lbl.TextAlign = isMe ? ContentAlignment.MiddleRight : ContentAlignment.MiddleLeft;
            }
        }

        public MessagesItemControl(Message message)
        {
            InitializeComponent();
            Message = message;
        }
    }
}
