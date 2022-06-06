namespace MyCryptoWallet.WF
{
    partial class InfoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelOperation = new System.Windows.Forms.Panel();
            this.labelCoinCountValue = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelCoinCount = new System.Windows.Forms.Label();
            this.labelBalanceValue = new System.Windows.Forms.Label();
            this.labelBuyingCount = new System.Windows.Forms.Label();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.labelBalance = new System.Windows.Forms.Label();
            this.radioButtonSell = new System.Windows.Forms.RadioButton();
            this.radioButtonBuy = new System.Windows.Forms.RadioButton();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelUpdate = new System.Windows.Forms.Label();
            this.labelUpdateValue = new System.Windows.Forms.Label();
            this.labelCurrentPrice = new System.Windows.Forms.Label();
            this.labelCurrentPriceValue = new System.Windows.Forms.Label();
            this.labelHighDay = new System.Windows.Forms.Label();
            this.labelHighDayValue = new System.Windows.Forms.Label();
            this.labelMinDay = new System.Windows.Forms.Label();
            this.labelMinDayValue = new System.Windows.Forms.Label();
            this.labelPriceChangeDayPercent = new System.Windows.Forms.Label();
            this.labelPriceChangeDayPercerntValue = new System.Windows.Forms.Label();
            this.labelPriceChangeHourPercent = new System.Windows.Forms.Label();
            this.labelPriceChangeHourPercentValue = new System.Windows.Forms.Label();
            this.labelPriceChangeTwoWeekPercent = new System.Windows.Forms.Label();
            this.labelPriceChangeTwoWeekPercentValue = new System.Windows.Forms.Label();
            this.labelPriceChangeWeekPercent = new System.Windows.Forms.Label();
            this.labelPriceChangeWeekPercentValue = new System.Windows.Forms.Label();
            this.labelPriceChangeMonthPercent = new System.Windows.Forms.Label();
            this.labelPriceChangeMonthPercentValue = new System.Windows.Forms.Label();
            this.panelChart = new System.Windows.Forms.Panel();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.coinComboBox = new System.Windows.Forms.ComboBox();
            this.panelOperation.SuspendLayout();
            this.panelHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOperation
            // 
            this.panelOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelOperation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOperation.Controls.Add(this.labelCoinCountValue);
            this.panelOperation.Controls.Add(this.labelCost);
            this.panelOperation.Controls.Add(this.labelCoinCount);
            this.panelOperation.Controls.Add(this.labelBalanceValue);
            this.panelOperation.Controls.Add(this.labelBuyingCount);
            this.panelOperation.Controls.Add(this.buttonBuy);
            this.panelOperation.Controls.Add(this.labelBalance);
            this.panelOperation.Controls.Add(this.radioButtonSell);
            this.panelOperation.Controls.Add(this.radioButtonBuy);
            this.panelOperation.Controls.Add(this.textBoxCost);
            this.panelOperation.Controls.Add(this.textBoxCount);
            this.panelOperation.Location = new System.Drawing.Point(447, 51);
            this.panelOperation.Name = "panelOperation";
            this.panelOperation.Size = new System.Drawing.Size(197, 172);
            this.panelOperation.TabIndex = 21;
            // 
            // labelCoinCountValue
            // 
            this.labelCoinCountValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCoinCountValue.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCoinCountValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelCoinCountValue.Location = new System.Drawing.Point(95, 25);
            this.labelCoinCountValue.Name = "labelCoinCountValue";
            this.labelCoinCountValue.Size = new System.Drawing.Size(96, 18);
            this.labelCoinCountValue.TabIndex = 26;
            this.labelCoinCountValue.Text = "9999";
            this.labelCoinCountValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelCost.Location = new System.Drawing.Point(3, 75);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(87, 20);
            this.labelCost.TabIndex = 28;
            this.labelCost.Text = "Стоймость";
            // 
            // labelCoinCount
            // 
            this.labelCoinCount.AutoSize = true;
            this.labelCoinCount.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCoinCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelCoinCount.Location = new System.Drawing.Point(3, 24);
            this.labelCoinCount.Name = "labelCoinCount";
            this.labelCoinCount.Size = new System.Drawing.Size(54, 20);
            this.labelCoinCount.TabIndex = 26;
            this.labelCoinCount.Text = "Монет";
            // 
            // labelBalanceValue
            // 
            this.labelBalanceValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBalanceValue.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBalanceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelBalanceValue.Location = new System.Drawing.Point(95, 3);
            this.labelBalanceValue.Name = "labelBalanceValue";
            this.labelBalanceValue.Size = new System.Drawing.Size(96, 18);
            this.labelBalanceValue.TabIndex = 26;
            this.labelBalanceValue.Text = "9999 $";
            this.labelBalanceValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelBuyingCount
            // 
            this.labelBuyingCount.AutoSize = true;
            this.labelBuyingCount.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBuyingCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelBuyingCount.Location = new System.Drawing.Point(3, 46);
            this.labelBuyingCount.Name = "labelBuyingCount";
            this.labelBuyingCount.Size = new System.Drawing.Size(93, 20);
            this.labelBuyingCount.TabIndex = 28;
            this.labelBuyingCount.Text = "Количество";
            // 
            // buttonBuy
            // 
            this.buttonBuy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.buttonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuy.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonBuy.Location = new System.Drawing.Point(3, 134);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(188, 28);
            this.buttonBuy.TabIndex = 27;
            this.buttonBuy.Text = "Купить/Продать";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelBalance.Location = new System.Drawing.Point(3, 3);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(60, 20);
            this.labelBalance.TabIndex = 26;
            this.labelBalance.Text = "Баланс";
            // 
            // radioButtonSell
            // 
            this.radioButtonSell.AutoSize = true;
            this.radioButtonSell.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.radioButtonSell.Location = new System.Drawing.Point(105, 104);
            this.radioButtonSell.Name = "radioButtonSell";
            this.radioButtonSell.Size = new System.Drawing.Size(87, 24);
            this.radioButtonSell.TabIndex = 20;
            this.radioButtonSell.TabStop = true;
            this.radioButtonSell.Text = "Продать";
            this.radioButtonSell.UseVisualStyleBackColor = true;
            // 
            // radioButtonBuy
            // 
            this.radioButtonBuy.AutoSize = true;
            this.radioButtonBuy.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.radioButtonBuy.Location = new System.Drawing.Point(11, 104);
            this.radioButtonBuy.Name = "radioButtonBuy";
            this.radioButtonBuy.Size = new System.Drawing.Size(75, 24);
            this.radioButtonBuy.TabIndex = 19;
            this.radioButtonBuy.TabStop = true;
            this.radioButtonBuy.Text = "Купить";
            this.radioButtonBuy.UseVisualStyleBackColor = true;
            this.radioButtonBuy.CheckedChanged += new System.EventHandler(this.radioButtonBuy_CheckedChanged);
            // 
            // textBoxCost
            // 
            this.textBoxCost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.textBoxCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.textBoxCost.Location = new System.Drawing.Point(103, 75);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(88, 23);
            this.textBoxCost.TabIndex = 18;
            this.textBoxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBoxCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCost_KeyUp);
            // 
            // textBoxCount
            // 
            this.textBoxCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.textBoxCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.textBoxCount.Location = new System.Drawing.Point(103, 46);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(88, 23);
            this.textBoxCount.TabIndex = 17;
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBoxCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCount_KeyUp);
            // 
            // labelUpdate
            // 
            this.labelUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelUpdate.Location = new System.Drawing.Point(319, 24);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(182, 20);
            this.labelUpdate.TabIndex = 22;
            this.labelUpdate.Text = "Последнее обновление :";
            // 
            // labelUpdateValue
            // 
            this.labelUpdateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUpdateValue.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUpdateValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelUpdateValue.Location = new System.Drawing.Point(507, 24);
            this.labelUpdateValue.Name = "labelUpdateValue";
            this.labelUpdateValue.Size = new System.Drawing.Size(137, 18);
            this.labelUpdateValue.TabIndex = 23;
            this.labelUpdateValue.Text = "99.99.9999 99:99:99";
            this.labelUpdateValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCurrentPrice
            // 
            this.labelCurrentPrice.AutoSize = true;
            this.labelCurrentPrice.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelCurrentPrice.Location = new System.Drawing.Point(122, 23);
            this.labelCurrentPrice.Name = "labelCurrentPrice";
            this.labelCurrentPrice.Size = new System.Drawing.Size(51, 20);
            this.labelCurrentPrice.TabIndex = 24;
            this.labelCurrentPrice.Text = "Цена :";
            // 
            // labelCurrentPriceValue
            // 
            this.labelCurrentPriceValue.AutoSize = true;
            this.labelCurrentPriceValue.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCurrentPriceValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelCurrentPriceValue.Location = new System.Drawing.Point(180, 24);
            this.labelCurrentPriceValue.Name = "labelCurrentPriceValue";
            this.labelCurrentPriceValue.Size = new System.Drawing.Size(53, 20);
            this.labelCurrentPriceValue.TabIndex = 24;
            this.labelCurrentPriceValue.Text = "9999 $";
            // 
            // labelHighDay
            // 
            this.labelHighDay.AutoSize = true;
            this.labelHighDay.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHighDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelHighDay.Location = new System.Drawing.Point(4, 3);
            this.labelHighDay.Name = "labelHighDay";
            this.labelHighDay.Size = new System.Drawing.Size(118, 20);
            this.labelHighDay.TabIndex = 24;
            this.labelHighDay.Text = "Максимум 24ч :";
            // 
            // labelHighDayValue
            // 
            this.labelHighDayValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHighDayValue.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelHighDayValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelHighDayValue.Location = new System.Drawing.Point(123, 4);
            this.labelHighDayValue.Name = "labelHighDayValue";
            this.labelHighDayValue.Size = new System.Drawing.Size(69, 18);
            this.labelHighDayValue.TabIndex = 24;
            this.labelHighDayValue.Text = "9999 $";
            this.labelHighDayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMinDay
            // 
            this.labelMinDay.AutoSize = true;
            this.labelMinDay.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMinDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelMinDay.Location = new System.Drawing.Point(4, 23);
            this.labelMinDay.Name = "labelMinDay";
            this.labelMinDay.Size = new System.Drawing.Size(110, 20);
            this.labelMinDay.TabIndex = 24;
            this.labelMinDay.Text = "Минимум 24ч :";
            // 
            // labelMinDayValue
            // 
            this.labelMinDayValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMinDayValue.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMinDayValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelMinDayValue.Location = new System.Drawing.Point(123, 25);
            this.labelMinDayValue.Name = "labelMinDayValue";
            this.labelMinDayValue.Size = new System.Drawing.Size(69, 18);
            this.labelMinDayValue.TabIndex = 24;
            this.labelMinDayValue.Text = "9999 $";
            this.labelMinDayValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPriceChangeDayPercent
            // 
            this.labelPriceChangeDayPercent.AutoSize = true;
            this.labelPriceChangeDayPercent.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceChangeDayPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelPriceChangeDayPercent.Location = new System.Drawing.Point(6, 63);
            this.labelPriceChangeDayPercent.Name = "labelPriceChangeDayPercent";
            this.labelPriceChangeDayPercent.Size = new System.Drawing.Size(76, 20);
            this.labelPriceChangeDayPercent.TabIndex = 24;
            this.labelPriceChangeDayPercent.Text = "За сутки :";
            // 
            // labelPriceChangeDayPercerntValue
            // 
            this.labelPriceChangeDayPercerntValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPriceChangeDayPercerntValue.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceChangeDayPercerntValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelPriceChangeDayPercerntValue.Location = new System.Drawing.Point(123, 64);
            this.labelPriceChangeDayPercerntValue.Name = "labelPriceChangeDayPercerntValue";
            this.labelPriceChangeDayPercerntValue.Size = new System.Drawing.Size(69, 18);
            this.labelPriceChangeDayPercerntValue.TabIndex = 24;
            this.labelPriceChangeDayPercerntValue.Text = "999%";
            this.labelPriceChangeDayPercerntValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPriceChangeHourPercent
            // 
            this.labelPriceChangeHourPercent.AutoSize = true;
            this.labelPriceChangeHourPercent.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceChangeHourPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelPriceChangeHourPercent.Location = new System.Drawing.Point(6, 43);
            this.labelPriceChangeHourPercent.Name = "labelPriceChangeHourPercent";
            this.labelPriceChangeHourPercent.Size = new System.Drawing.Size(62, 20);
            this.labelPriceChangeHourPercent.TabIndex = 24;
            this.labelPriceChangeHourPercent.Text = "За час :";
            // 
            // labelPriceChangeHourPercentValue
            // 
            this.labelPriceChangeHourPercentValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPriceChangeHourPercentValue.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceChangeHourPercentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelPriceChangeHourPercentValue.Location = new System.Drawing.Point(123, 44);
            this.labelPriceChangeHourPercentValue.Name = "labelPriceChangeHourPercentValue";
            this.labelPriceChangeHourPercentValue.Size = new System.Drawing.Size(69, 18);
            this.labelPriceChangeHourPercentValue.TabIndex = 24;
            this.labelPriceChangeHourPercentValue.Text = "999%";
            this.labelPriceChangeHourPercentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPriceChangeTwoWeekPercent
            // 
            this.labelPriceChangeTwoWeekPercent.AutoSize = true;
            this.labelPriceChangeTwoWeekPercent.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceChangeTwoWeekPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelPriceChangeTwoWeekPercent.Location = new System.Drawing.Point(6, 103);
            this.labelPriceChangeTwoWeekPercent.Name = "labelPriceChangeTwoWeekPercent";
            this.labelPriceChangeTwoWeekPercent.Size = new System.Drawing.Size(117, 20);
            this.labelPriceChangeTwoWeekPercent.TabIndex = 24;
            this.labelPriceChangeTwoWeekPercent.Text = "За две недели :";
            // 
            // labelPriceChangeTwoWeekPercentValue
            // 
            this.labelPriceChangeTwoWeekPercentValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPriceChangeTwoWeekPercentValue.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceChangeTwoWeekPercentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelPriceChangeTwoWeekPercentValue.Location = new System.Drawing.Point(123, 104);
            this.labelPriceChangeTwoWeekPercentValue.Name = "labelPriceChangeTwoWeekPercentValue";
            this.labelPriceChangeTwoWeekPercentValue.Size = new System.Drawing.Size(69, 18);
            this.labelPriceChangeTwoWeekPercentValue.TabIndex = 24;
            this.labelPriceChangeTwoWeekPercentValue.Text = "999%";
            this.labelPriceChangeTwoWeekPercentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPriceChangeWeekPercent
            // 
            this.labelPriceChangeWeekPercent.AutoSize = true;
            this.labelPriceChangeWeekPercent.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceChangeWeekPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelPriceChangeWeekPercent.Location = new System.Drawing.Point(6, 83);
            this.labelPriceChangeWeekPercent.Name = "labelPriceChangeWeekPercent";
            this.labelPriceChangeWeekPercent.Size = new System.Drawing.Size(91, 20);
            this.labelPriceChangeWeekPercent.TabIndex = 24;
            this.labelPriceChangeWeekPercent.Text = "За неделю :";
            // 
            // labelPriceChangeWeekPercentValue
            // 
            this.labelPriceChangeWeekPercentValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPriceChangeWeekPercentValue.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceChangeWeekPercentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelPriceChangeWeekPercentValue.Location = new System.Drawing.Point(123, 84);
            this.labelPriceChangeWeekPercentValue.Name = "labelPriceChangeWeekPercentValue";
            this.labelPriceChangeWeekPercentValue.Size = new System.Drawing.Size(69, 18);
            this.labelPriceChangeWeekPercentValue.TabIndex = 24;
            this.labelPriceChangeWeekPercentValue.Text = "999%";
            this.labelPriceChangeWeekPercentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPriceChangeMonthPercent
            // 
            this.labelPriceChangeMonthPercent.AutoSize = true;
            this.labelPriceChangeMonthPercent.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceChangeMonthPercent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelPriceChangeMonthPercent.Location = new System.Drawing.Point(7, 123);
            this.labelPriceChangeMonthPercent.Name = "labelPriceChangeMonthPercent";
            this.labelPriceChangeMonthPercent.Size = new System.Drawing.Size(81, 20);
            this.labelPriceChangeMonthPercent.TabIndex = 24;
            this.labelPriceChangeMonthPercent.Text = "За месяц :";
            // 
            // labelPriceChangeMonthPercentValue
            // 
            this.labelPriceChangeMonthPercentValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPriceChangeMonthPercentValue.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceChangeMonthPercentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelPriceChangeMonthPercentValue.Location = new System.Drawing.Point(123, 125);
            this.labelPriceChangeMonthPercentValue.Name = "labelPriceChangeMonthPercentValue";
            this.labelPriceChangeMonthPercentValue.Size = new System.Drawing.Size(69, 18);
            this.labelPriceChangeMonthPercentValue.TabIndex = 24;
            this.labelPriceChangeMonthPercentValue.Text = "999%";
            this.labelPriceChangeMonthPercentValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelChart
            // 
            this.panelChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelChart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelChart.Location = new System.Drawing.Point(12, 51);
            this.panelChart.Name = "panelChart";
            this.panelChart.Size = new System.Drawing.Size(429, 330);
            this.panelChart.TabIndex = 25;
            // 
            // panelHistory
            // 
            this.panelHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.panelHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHistory.Controls.Add(this.labelHighDay);
            this.panelHistory.Controls.Add(this.labelMinDay);
            this.panelHistory.Controls.Add(this.labelPriceChangeDayPercent);
            this.panelHistory.Controls.Add(this.labelPriceChangeHourPercentValue);
            this.panelHistory.Controls.Add(this.labelPriceChangeTwoWeekPercent);
            this.panelHistory.Controls.Add(this.labelPriceChangeWeekPercentValue);
            this.panelHistory.Controls.Add(this.labelPriceChangeMonthPercent);
            this.panelHistory.Controls.Add(this.labelPriceChangeMonthPercentValue);
            this.panelHistory.Controls.Add(this.labelPriceChangeWeekPercent);
            this.panelHistory.Controls.Add(this.labelPriceChangeTwoWeekPercentValue);
            this.panelHistory.Controls.Add(this.labelPriceChangeHourPercent);
            this.panelHistory.Controls.Add(this.labelPriceChangeDayPercerntValue);
            this.panelHistory.Controls.Add(this.labelHighDayValue);
            this.panelHistory.Controls.Add(this.labelMinDayValue);
            this.panelHistory.Location = new System.Drawing.Point(447, 229);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(197, 152);
            this.panelHistory.TabIndex = 26;
            // 
            // coinComboBox
            // 
            this.coinComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coinComboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coinComboBox.FormattingEnabled = true;
            this.coinComboBox.Location = new System.Drawing.Point(12, 17);
            this.coinComboBox.Name = "coinComboBox";
            this.coinComboBox.Size = new System.Drawing.Size(104, 28);
            this.coinComboBox.TabIndex = 27;
            this.coinComboBox.SelectedIndexChanged += new System.EventHandler(this.coinComboBox_SelectedIndexChanged);
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(656, 390);
            this.Controls.Add(this.coinComboBox);
            this.Controls.Add(this.panelHistory);
            this.Controls.Add(this.panelChart);
            this.Controls.Add(this.labelCurrentPriceValue);
            this.Controls.Add(this.labelCurrentPrice);
            this.Controls.Add(this.labelUpdateValue);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.panelOperation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelOperation.ResumeLayout(false);
            this.panelOperation.PerformLayout();
            this.panelHistory.ResumeLayout(false);
            this.panelHistory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panelOperation;
        private TextBox textBoxCost;
        private TextBox textBoxCount;
        private RadioButton radioButtonSell;
        private RadioButton radioButtonBuy;
        private Label labelUpdate;
        private Label labelUpdateValue;
        private Label labelCurrentPrice;
        private Label labelCurrentPriceValue;
        private Label labelHighDay;
        private Label labelHighDayValue;
        private Label labelMinDay;
        private Label labelMinDayValue;
        private Label labelPriceChangeDayPercent;
        private Label labelPriceChangeDayPercerntValue;
        private Label labelPriceChangeHourPercent;
        private Label labelPriceChangeHourPercentValue;
        private Label labelPriceChangeTwoWeekPercent;
        private Label labelPriceChangeTwoWeekPercentValue;
        private Label labelPriceChangeWeekPercent;
        private Label labelPriceChangeWeekPercentValue;
        private Label labelPriceChangeMonthPercent;
        private Label labelPriceChangeMonthPercentValue;
        private Panel panelChart;
        private Label labelBalance;
        private Label labelCost;
        private Label labelBuyingCount;
        private Button buttonBuy;
        private Label labelBalanceValue;
        private Label labelCoinCount;
        private Label labelCoinCountValue;
        private Panel panelHistory;
        private ComboBox coinComboBox;
    }
}