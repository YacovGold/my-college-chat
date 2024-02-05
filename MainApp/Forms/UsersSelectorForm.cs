using User = MainApp.Dal.Entities.User;

namespace MainApp.Forms
{
    public partial class UsersSelectorForm : Form
    {
        public event EventHandler<User> UserSelected;

        public UsersSelectorForm()
        {
            InitializeComponent();
            usersListControl1.UserSelected += UsersListControl1_UserSelected;
        }

        private void tb_filter_TextChanged(object sender, EventArgs e)
        {
            usersListControl1.SetFilter(tb_filter.Text);
            usersListControl1.RefreshData();
        }

        private void UsersListControl1_UserSelected(object sender, User user)
        {
            Close();
            UserSelected?.Invoke(this, user);
        }

        private void UsersSelector_Deactivate(object sender, EventArgs e)
        {
            Close();
        }
    }
}
