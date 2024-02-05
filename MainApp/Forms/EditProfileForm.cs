using MainApp.Dal.Entities;

namespace MainApp.Forms
{
    public partial class EditProfileForm : Form
    {
        Factory _factory = Factory.Instance;
        User _user;

        public EditProfileForm()
        {
            _user = _factory.State.CurrentUser.ShallowCopy();
            InitializeComponent();
        }

        private void EditProfileForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void userProfileControl1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _user.ProfileImageLocation = openFileDialog1.FileName;
                RefreshData();
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            _user.Nick = tb_nick.Text;

            if (string.IsNullOrEmpty(_user.Nick))
            {
                MessageBox.Show("The nick shouldn't be empty");
                return;
            }

            _user.Gender = (GenderType)Enum.Parse(typeof(GenderType), cb_gender.Text);
            _factory.State.CurrentUser = _factory.UsersDal.UpdateUser(_user);
            Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cb_gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            _user.Gender = (GenderType)Enum.Parse(typeof(GenderType), cb_gender.Text);
            RefreshData();
        }

        private void RefreshData()
        {
            userProfileControl1.User = _user;
            tb_nick.Text = _user.Nick;
            cb_gender.Text = (_user.Gender == GenderType.Female ? GenderType.Female : GenderType.Male).ToString();
        }
    }
}
