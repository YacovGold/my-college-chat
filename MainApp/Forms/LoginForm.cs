namespace MainApp.forms
{
    internal partial class LoginForm : Form
    {
        Factory _factory;

        public LoginForm()
        {
            _factory = Factory.Instance;
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tb_name.Text = $"name_{Guid.NewGuid().ToString("N").Substring(0, 5)}";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var nick = tb_name.Text;

            if(string.IsNullOrEmpty(nick) )
            {
                MessageBox.Show("The nick shouldn't be empty");
                return;
            }

            _factory.State.CurrentUser = _factory.UsersDal.Login(nick);
            if (_factory.State.CurrentUser == null)
            {
                _factory.State.CurrentUser = _factory.UsersDal.Register(nick);
                MessageBox.Show("Your registered :)");
            }

            Hide();
            MainForm mainForm = new MainForm();
            mainForm.FormClosed += (s, args) => Close();
            mainForm.Show();
        }
    }
}
