using MainApp.Dal.Entities;

namespace MainApp.Forms
{
    public partial class CreateGroupForm : Form
    {
        public CreateGroupForm()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            var users = usersListControl1.SelectedUsers.ToList();
            users.Add(Factory.Instance.State.CurrentUser);

            Factory.Instance.MessagesDal.CreateChat(new Chat
            {
                ChatType = ChatType.Group,
                Users = users.Select(v => v.UserId).Distinct().ToArray(),
                GroupTitle = tb_groupTitle.Text,
                UpdatedAt = DateTime.UtcNow,
            });

            Close();
        }

        private void CloseHandler(object sender, EventArgs e)
        {
            Close();
        }
    }
}
