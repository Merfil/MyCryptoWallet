namespace MyCryptoWallet.WF
{
    partial class WalletForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.coinComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.labelEarnedMoneyValue = new System.Windows.Forms.Label();
            this.labelAmountInCountValue = new System.Windows.Forms.Label();
            this.labelTotalValue = new System.Windows.Forms.Label();
            this.dataGridViewWallets = new System.Windows.Forms.DataGridView();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.labelHistory = new System.Windows.Forms.Label();
            this.panelWallets = new System.Windows.Forms.Panel();
            this.labelWallets = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.labelSpentMoneyValue = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelAmountInCount = new System.Windows.Forms.Label();
            this.labelEarnedMoney = new System.Windows.Forms.Label();
            this.labelSpentMoney = new System.Windows.Forms.Label();
            this.labelStats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWallets)).BeginInit();
            this.panelHistory.SuspendLayout();
            this.panelWallets.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // coinComboBox
            // 
            this.coinComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.coinComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coinComboBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.coinComboBox.FormattingEnabled = true;
            this.coinComboBox.Location = new System.Drawing.Point(12, 12);
            this.coinComboBox.Name = "coinComboBox";
            this.coinComboBox.Size = new System.Drawing.Size(121, 23);
            this.coinComboBox.TabIndex = 0;
            this.coinComboBox.SelectedIndexChanged += new System.EventHandler(this.coinComboBox_SelectedIndexChanged);
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToAddRows = false;
            this.dataGridViewHistory.AllowUserToDeleteRows = false;
            this.dataGridViewHistory.AllowUserToResizeColumns = false;
            this.dataGridViewHistory.AllowUserToResizeRows = false;
            this.dataGridViewHistory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dataGridViewHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewHistory.EnableHeadersVisualStyles = false;
            this.dataGridViewHistory.GridColor = System.Drawing.Color.Black;
            this.dataGridViewHistory.Location = new System.Drawing.Point(8, 33);
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.RowHeadersVisible = false;
            this.dataGridViewHistory.RowTemplate.Height = 25;
            this.dataGridViewHistory.Size = new System.Drawing.Size(614, 128);
            this.dataGridViewHistory.TabIndex = 4;
            // 
            // labelEarnedMoneyValue
            // 
            this.labelEarnedMoneyValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEarnedMoneyValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.labelEarnedMoneyValue.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEarnedMoneyValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelEarnedMoneyValue.Location = new System.Drawing.Point(147, 65);
            this.labelEarnedMoneyValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelEarnedMoneyValue.Name = "labelEarnedMoneyValue";
            this.labelEarnedMoneyValue.Size = new System.Drawing.Size(242, 25);
            this.labelEarnedMoneyValue.TabIndex = 1;
            this.labelEarnedMoneyValue.Text = "value";
            this.labelEarnedMoneyValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelAmountInCountValue
            // 
            this.labelAmountInCountValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAmountInCountValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.labelAmountInCountValue.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAmountInCountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelAmountInCountValue.Location = new System.Drawing.Point(147, 95);
            this.labelAmountInCountValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelAmountInCountValue.Name = "labelAmountInCountValue";
            this.labelAmountInCountValue.Size = new System.Drawing.Size(242, 25);
            this.labelAmountInCountValue.TabIndex = 1;
            this.labelAmountInCountValue.Text = "value";
            this.labelAmountInCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotalValue
            // 
            this.labelTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.labelTotalValue.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelTotalValue.Location = new System.Drawing.Point(147, 125);
            this.labelTotalValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.labelTotalValue.Name = "labelTotalValue";
            this.labelTotalValue.Size = new System.Drawing.Size(242, 25);
            this.labelTotalValue.TabIndex = 5;
            this.labelTotalValue.Text = "value";
            this.labelTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridViewWallets
            // 
            this.dataGridViewWallets.AllowUserToAddRows = false;
            this.dataGridViewWallets.AllowUserToDeleteRows = false;
            this.dataGridViewWallets.AllowUserToResizeColumns = false;
            this.dataGridViewWallets.AllowUserToResizeRows = false;
            this.dataGridViewWallets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridViewWallets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewWallets.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.dataGridViewWallets.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewWallets.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewWallets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWallets.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewWallets.EnableHeadersVisualStyles = false;
            this.dataGridViewWallets.GridColor = System.Drawing.Color.Black;
            this.dataGridViewWallets.Location = new System.Drawing.Point(8, 33);
            this.dataGridViewWallets.Name = "dataGridViewWallets";
            this.dataGridViewWallets.RowHeadersVisible = false;
            this.dataGridViewWallets.RowTemplate.Height = 25;
            this.dataGridViewWallets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWallets.Size = new System.Drawing.Size(210, 117);
            this.dataGridViewWallets.TabIndex = 6;
            // 
            // panelHistory
            // 
            this.panelHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHistory.Controls.Add(this.labelHistory);
            this.panelHistory.Controls.Add(this.dataGridViewHistory);
            this.panelHistory.Location = new System.Drawing.Point(12, 207);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Padding = new System.Windows.Forms.Padding(5);
            this.panelHistory.Size = new System.Drawing.Size(632, 171);
            this.panelHistory.TabIndex = 7;
            // 
            // labelHistory
            // 
            this.labelHistory.AutoSize = true;
            this.labelHistory.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelHistory.ForeColor = System.Drawing.Color.White;
            this.labelHistory.Location = new System.Drawing.Point(8, 5);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(95, 25);
            this.labelHistory.TabIndex = 5;
            this.labelHistory.Text = "История";
            // 
            // panelWallets
            // 
            this.panelWallets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelWallets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWallets.Controls.Add(this.labelWallets);
            this.panelWallets.Controls.Add(this.dataGridViewWallets);
            this.panelWallets.Location = new System.Drawing.Point(417, 41);
            this.panelWallets.Name = "panelWallets";
            this.panelWallets.Padding = new System.Windows.Forms.Padding(5);
            this.panelWallets.Size = new System.Drawing.Size(227, 160);
            this.panelWallets.TabIndex = 8;
            // 
            // labelWallets
            // 
            this.labelWallets.AutoSize = true;
            this.labelWallets.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWallets.ForeColor = System.Drawing.Color.White;
            this.labelWallets.Location = new System.Drawing.Point(8, 5);
            this.labelWallets.Name = "labelWallets";
            this.labelWallets.Size = new System.Drawing.Size(82, 25);
            this.labelWallets.TabIndex = 0;
            this.labelWallets.Text = "Баланс";
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStats.Controls.Add(this.labelSpentMoneyValue);
            this.panelStats.Controls.Add(this.labelTotal);
            this.panelStats.Controls.Add(this.labelAmountInCount);
            this.panelStats.Controls.Add(this.labelEarnedMoney);
            this.panelStats.Controls.Add(this.labelSpentMoney);
            this.panelStats.Controls.Add(this.labelStats);
            this.panelStats.Controls.Add(this.labelTotalValue);
            this.panelStats.Controls.Add(this.labelEarnedMoneyValue);
            this.panelStats.Controls.Add(this.labelAmountInCountValue);
            this.panelStats.Location = new System.Drawing.Point(12, 41);
            this.panelStats.Name = "panelStats";
            this.panelStats.Padding = new System.Windows.Forms.Padding(5);
            this.panelStats.Size = new System.Drawing.Size(399, 160);
            this.panelStats.TabIndex = 9;
            // 
            // labelSpentMoneyValue
            // 
            this.labelSpentMoneyValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSpentMoneyValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.labelSpentMoneyValue.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpentMoneyValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelSpentMoneyValue.Location = new System.Drawing.Point(147, 35);
            this.labelSpentMoneyValue.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.labelSpentMoneyValue.Name = "labelSpentMoneyValue";
            this.labelSpentMoneyValue.Size = new System.Drawing.Size(242, 25);
            this.labelSpentMoneyValue.TabIndex = 8;
            this.labelSpentMoneyValue.Text = "value";
            this.labelSpentMoneyValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelTotal.Location = new System.Drawing.Point(13, 125);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(8, 5, 3, 5);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(55, 25);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "Итог";
            // 
            // labelAmountInCount
            // 
            this.labelAmountInCount.AutoSize = true;
            this.labelAmountInCount.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAmountInCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelAmountInCount.Location = new System.Drawing.Point(13, 95);
            this.labelAmountInCount.Margin = new System.Windows.Forms.Padding(8, 5, 3, 0);
            this.labelAmountInCount.Name = "labelAmountInCount";
            this.labelAmountInCount.Size = new System.Drawing.Size(97, 25);
            this.labelAmountInCount.TabIndex = 7;
            this.labelAmountInCount.Text = "Монет на";
            // 
            // labelEarnedMoney
            // 
            this.labelEarnedMoney.AutoSize = true;
            this.labelEarnedMoney.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEarnedMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelEarnedMoney.Location = new System.Drawing.Point(13, 65);
            this.labelEarnedMoney.Margin = new System.Windows.Forms.Padding(8, 5, 3, 0);
            this.labelEarnedMoney.Name = "labelEarnedMoney";
            this.labelEarnedMoney.Size = new System.Drawing.Size(98, 25);
            this.labelEarnedMoney.TabIndex = 7;
            this.labelEarnedMoney.Text = "Получено";
            // 
            // labelSpentMoney
            // 
            this.labelSpentMoney.AutoSize = true;
            this.labelSpentMoney.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSpentMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelSpentMoney.Location = new System.Drawing.Point(13, 35);
            this.labelSpentMoney.Margin = new System.Windows.Forms.Padding(8, 10, 3, 0);
            this.labelSpentMoney.Name = "labelSpentMoney";
            this.labelSpentMoney.Size = new System.Drawing.Size(110, 25);
            this.labelSpentMoney.TabIndex = 7;
            this.labelSpentMoney.Text = "Потрачено";
            // 
            // labelStats
            // 
            this.labelStats.AutoSize = true;
            this.labelStats.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelStats.ForeColor = System.Drawing.Color.White;
            this.labelStats.Location = new System.Drawing.Point(8, 5);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(126, 25);
            this.labelStats.TabIndex = 6;
            this.labelStats.Text = "Статистика";
            // 
            // WalletForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(656, 390);
            this.Controls.Add(this.panelWallets);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelHistory);
            this.Controls.Add(this.coinComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WalletForm";
            this.Text = "WalletForm";
            this.Load += new System.EventHandler(this.WalletForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWallets)).EndInit();
            this.panelHistory.ResumeLayout(false);
            this.panelHistory.PerformLayout();
            this.panelWallets.ResumeLayout(false);
            this.panelWallets.PerformLayout();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox coinComboBox;
        private DataGridView dataGridViewHistory;
        private Label labelEarnedMoneyValue;
        private Label labelAmountInCountValue;
        private Label labelTotalValue;
        private DataGridView dataGridViewWallets;
        private Panel panelHistory;
        private Label labelHistory;
        private Panel panelWallets;
        private Label labelWallets;
        private Panel panelStats;
        private Label labelStats;
        private Label labelSpentMoney;
        private Label labelSpentMoneyValue;
        private Label labelTotal;
        private Label labelAmountInCount;
        private Label labelEarnedMoney;
    }
}