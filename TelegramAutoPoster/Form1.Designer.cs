namespace TelegramAutoPoster
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtChatId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnAddMessage;
        private System.Windows.Forms.Button btnRemoveMessage;
        private System.Windows.Forms.ListBox lstMessages;

        private System.Windows.Forms.Button btnToggleAuto;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtChatId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnAddMessage = new System.Windows.Forms.Button();
            this.btnRemoveMessage = new System.Windows.Forms.Button();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.btnToggleAuto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            this.label1.Text = "Bot Token:";
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.AutoSize = true;
            this.txtToken.Location = new System.Drawing.Point(20, 45);
            this.txtToken.Width = 350;
            this.label2.Text = "Chat ID:";
            this.label2.Location = new System.Drawing.Point(20, 80);
            this.label2.AutoSize = true;
            this.txtChatId.Location = new System.Drawing.Point(20, 105);
            this.txtChatId.Width = 350;
            this.label3.Text = "Интервал (мин.):";
            this.label3.Location = new System.Drawing.Point(20, 140);
            this.label3.AutoSize = true;
            this.numInterval.Location = new System.Drawing.Point(20, 165);
            this.numInterval.Minimum = 1;
            this.numInterval.Maximum = 1440;
            this.numInterval.Value = 5;
            this.label4.Text = "Сообщение:";
            this.label4.Location = new System.Drawing.Point(20, 200);
            this.label4.AutoSize = true;
            this.txtMessage.Location = new System.Drawing.Point(20, 225);
            this.txtMessage.Width = 350;
            this.txtMessage.Height = 60;
            this.txtMessage.Multiline = true;
            this.btnAddMessage.Text = "Добавить";
            this.btnAddMessage.Location = new System.Drawing.Point(380, 225);
            this.btnAddMessage.Size = new System.Drawing.Size(100, 30);
            this.btnAddMessage.Click += new System.EventHandler(this.btnAddMessage_Click);
            this.btnRemoveMessage.Text = "Удалить";
            this.btnRemoveMessage.Location = new System.Drawing.Point(380, 255);
            this.btnRemoveMessage.Size = new System.Drawing.Size(100, 30);
            this.btnRemoveMessage.Click += new System.EventHandler(this.btnRemoveMessage_Click);
            this.lstMessages.Location = new System.Drawing.Point(20, 300);
            this.lstMessages.Width = 460;
            this.lstMessages.Height = 120;
            this.btnToggleAuto.Text = "Включить авто-постинг";
            this.btnToggleAuto.Location = new System.Drawing.Point(20, 430);
            this.btnToggleAuto.Size = new System.Drawing.Size(200, 35);
            this.btnToggleAuto.Click += new System.EventHandler(this.btnToggleAuto_Click);
            this.ClientSize = new System.Drawing.Size(500, 480);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChatId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numInterval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnAddMessage);
            this.Controls.Add(this.btnRemoveMessage);
            this.Controls.Add(this.lstMessages);
            this.Controls.Add(this.btnToggleAuto);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Text = "Telegram Auto Poster";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
