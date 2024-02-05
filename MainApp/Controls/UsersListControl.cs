using MainApp.Dal;
using MainApp.Dal.Entities;
using System.Data;
using System.Linq;

namespace MainApp.Controls
{
    public partial class UsersListControl : UserControl, IDisposable
    {
        readonly Color SELECTED_COLOR = Color.FromArgb(250, 255, 255, 204);

        UsersDal _usersDal;
        string _filter;

        public event EventHandler<User> UserSelected;

        public IList<User> SelectedUsers
        {
            get => flowLayoutPanel1.Controls
                .Cast<UsersSelectorItemControl>()
                .Where(v => v.BackColor == SELECTED_COLOR)
                .Select(v => (User)v.Tag)
                .ToList();
        }

        public void SetFilter(string filter)
        {
            _filter = filter;
            RefreshData();
        }

        public UsersListControl()
        {
            InitializeComponent();
        }

        private void UsersListControl_Load(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }
            _usersDal = Factory.Instance.UsersDal;
            RefreshData();
        }

        public void RefreshData()
        {
            var users = _usersDal.ListUsers(string.IsNullOrWhiteSpace(_filter) ? null : _filter);
            ClearControls();

            int controlWidth = flowLayoutPanel1.Width - SystemInformation.VerticalScrollBarWidth - 10;

            foreach (var user in users.Where(v => v.UserId != Factory.Instance.State.CurrentUser.UserId))
            {
                var userItem = new UsersSelectorItemControl(user);
                userItem.Click += HandleSelected;
                userItem.Width = controlWidth;
                userItem.Tag = user;
                flowLayoutPanel1.Controls.Add(userItem);
            }
        }

        public new void Dispose()
        {
            base.Dispose();
            ClearControls();
        }

        private void HandleSelected(object sender, User user)
        {
            var c = flowLayoutPanel1.Controls
                .Cast<UsersSelectorItemControl>()
                .Where(v => v.Tag == user)
                .First();

            c.BackColor = c.BackColor == SELECTED_COLOR ? Color.Empty : SELECTED_COLOR;

            UserSelected?.Invoke(this, user);
        }

        private void ClearControls()
        {
            flowLayoutPanel1.Controls
               .Cast<UsersSelectorItemControl>()
               .ToList()
               .ForEach(v => v.Click -= HandleSelected);
            flowLayoutPanel1.Controls.Clear();
        }
    }
}
