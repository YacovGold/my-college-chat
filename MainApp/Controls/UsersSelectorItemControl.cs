using MainApp.Dal.Entities;

namespace MainApp.Controls
{
    public partial class UsersSelectorItemControl : EventBubblerControl
    {
        public new event EventHandler<User> Click;

        public UsersSelectorItemControl(User user)
        {
            InitializeComponent();
            userProfile1.User = user;
            lbl_nick.Text = user.Nick;

            base.Click += (s, e) => Click?.Invoke(this, user);
        }
    }
}
