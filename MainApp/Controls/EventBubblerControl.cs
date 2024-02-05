namespace MainApp.Controls
{
    public class EventBubblerControl : UserControl
    {
        public new event EventHandler<EventArgs> Click;

        public EventBubblerControl()
        {
            Load += EventBubblerControl_Load;
        }

        private void EventBubblerControl_Load(object sender, EventArgs e)
        {
            Trap(this);
            base.Click += (s, e) => Click?.Invoke(this, e);
        }

        private void Trap(Control baseCtrl)
        {
            foreach (Control ctrl in baseCtrl.Controls)
            {
                ctrl.Click += (s, e) => Click?.Invoke(this, e);
                Trap(ctrl);
            }
        }
    }
}
