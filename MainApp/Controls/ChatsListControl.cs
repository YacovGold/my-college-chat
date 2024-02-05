using MainApp.Dal.Entities;
using MongoDB.Bson;
using System.Data;

namespace MainApp.Controls
{
    public partial class ChatsListControl : UserControl
    {
        private DateTime _lastDate = DateTime.MinValue;

        public event EventHandler<Chat> ChatSelected;

        public ChatsListControl()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            var mdal = Factory.Instance.MessagesDal;
            var chats = mdal.ListChats(new[] { Factory.Instance.State.CurrentUser.UserId });
            flowLayoutPanel1.Controls.Cast<ChatsItemControl>().ToList().ForEach(v => v.Click -= PreivewItem_Click);
            flowLayoutPanel1.Controls.Clear();

            int controlWidth = flowLayoutPanel1.Width - SystemInformation.VerticalScrollBarWidth - 10;

            foreach (var chat in chats)
            {
                var preivewItem = new ChatsItemControl(chat);
                preivewItem.Click += PreivewItem_Click;
                preivewItem.Width = controlWidth;
                preivewItem.Tag = chat;
                flowLayoutPanel1.Controls.Add(preivewItem);

                if (_lastDate < chat.UpdatedAt)
                {
                    _lastDate = chat.UpdatedAt;
                }
            }
        }

        private void PreivewItem_Click(object sender, EventArgs e)
        {
            var chatId = (Chat)((Control)sender).Tag;
            ChatSelected?.Invoke(this, chatId);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DesignMode)
            {
                return;
            }

            var mp = Factory.Instance.MessagesDal.ListChats(new[] { Factory.Instance.State.CurrentUser.UserId });

            if (mp.Count == 0)
            {
                flowLayoutPanel1.Controls.Clear();
                return;
            }

            if (mp.OrderByDescending(v => v.UpdatedAt).First().UpdatedAt > _lastDate)
            {
                RefreshData();
            }
        }
    }
}
