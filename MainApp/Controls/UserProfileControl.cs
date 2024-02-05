using MainApp.Dal.Entities;

namespace MainApp.Controls
{
    public partial class UserProfileControl : EventBubblerControl
    {
        public UserProfileControl()
        {
            InitializeComponent();
        }

        public User User
        {
            set
            {
                if (value.ProfileImageLocation != null)
                {
                    pb_figure.Image = new Bitmap(value.ProfileImageLocation);
                    return;
                }

                pb_figure.Image = value.Gender == GenderType.Male ? Properties.Resources.ManFigure : Properties.Resources.WomenFigure;
            }
        }
    }
}
