using MongoDB.Bson;
using System.Data;

namespace MainApp.Controls
{
    public partial class MessagesControl : UserControl
    {
        ObjectId _chatId = ObjectId.Empty;

        public MessagesControl()
        {
            InitializeComponent();
        }

        public ObjectId ChatId
        {
            get { return _chatId; }
            set
            {
                if (_chatId == value) { return; }

                _chatId = value;
                tableLayoutPanel1.Controls.Clear();
                tableLayoutPanel1.RowCount = 1;
                RefreshData();
                ScrollDown();
            }
        }

        public void RefreshData()
        {
            if (_chatId == ObjectId.Empty) { return; }

            var isScroll = IsLastControlFullyVisible(tableLayoutPanel1);
            var messages = Factory.Instance.MessagesDal.ListMessages(_chatId);

            // Sync
            var data = tableLayoutPanel1.Controls.Cast<MessagesItemControl>()
                .Select(v => new { cur = v, dbItem = messages.FirstOrDefault(x => x.MessageId == v.Message.MessageId) });

            // Del
            data.Where(v => v.dbItem == null)
                .ToList()
                .ForEach(v =>
                {
                    tableLayoutPanel1.Controls.Remove(v.cur);
                    tableLayoutPanel1.RowCount--;
                });
            data = data.Where(v => v.dbItem != null);

            // Update
            data.Where(v => v.cur.Message.UpdatedOn != v.dbItem.UpdatedOn)
               .ToList()
               .ForEach(v => v.cur.Message = v.dbItem);


            // Add
            var existing = tableLayoutPanel1.Controls.Cast<MessagesItemControl>();
            var newMessages = messages.Where(v => !existing.Any(x => x.Message.MessageId == v.MessageId));
            foreach (var message in newMessages)
            {
                var messageControl = new MessagesItemControl(message);
                if (message.UserId == Factory.Instance.State.CurrentUser.UserId)
                {
                    messageControl.Anchor = AnchorStyles.Right;
                }
                else
                {
                    messageControl.Anchor = AnchorStyles.Left;
                }
                tableLayoutPanel1.Controls.Add(messageControl);
                tableLayoutPanel1.RowCount++;
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            if (isScroll)
            {
                ScrollDown();
            }
        }
        public void ScrollDown()
        {
            if (tableLayoutPanel1.Controls.Count > 0)
            {
                tableLayoutPanel1.ScrollControlIntoView(tableLayoutPanel1.Controls[tableLayoutPanel1.Controls.Count - 1]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                RefreshData();
            }
        }

        bool IsLastControlFullyVisible(TableLayoutPanel tableLayoutPanel)
        {
            if (tableLayoutPanel.Controls.Count == 0)
            {
                return false;
            }

            var lastControlH = tableLayoutPanel.Controls[tableLayoutPanel.Controls.Count - 1].Height;
            var tol = lastControlH / 2;
            var n1 = tableLayoutPanel.VerticalScroll.Value + tol;
            var n2 = tableLayoutPanel.VerticalScroll.Maximum - tableLayoutPanel.VerticalScroll.LargeChange;
            var result = n1 >= n2;
            return result;
        }
    }
}
