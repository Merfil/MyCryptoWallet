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
            this.coinComboBox = new System.Windows.Forms.ComboBox();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelCoinCount = new System.Windows.Forms.Label();
            this.labelBalance = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // coinComboBox
            // 
            this.coinComboBox.BackColor = System.Drawing.SystemColors.Control;
            this.coinComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coinComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.coinComboBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.coinComboBox.FormattingEnabled = true;
            this.coinComboBox.Location = new System.Drawing.Point(12, 12);
            this.coinComboBox.Name = "coinComboBox";
            this.coinComboBox.Size = new System.Drawing.Size(137, 33);
            this.coinComboBox.TabIndex = 1;
            this.coinComboBox.SelectedIndexChanged += new System.EventHandler(this.coinComboBox_SelectedIndexChanged);
            // 
            // buttonBuy
            // 
            this.buttonBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBuy.Location = new System.Drawing.Point(8, 176);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(221, 34);
            this.buttonBuy.TabIndex = 16;
            this.buttonBuy.Text = "Купить";
            this.buttonBuy.UseVisualStyleBackColor = true;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(8, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(117, 24);
            this.label12.TabIndex = 11;
            this.label12.Text = "Количество";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(8, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 24);
            this.label13.TabIndex = 15;
            this.label13.Text = "Стоймость";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(8, 53);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(221, 45);
            this.trackBar1.TabIndex = 13;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(390, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 24);
            this.label14.TabIndex = 19;
            this.label14.Text = "На счету";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(390, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 24);
            this.label15.TabIndex = 20;
            this.label15.Text = "Баланс";
            // 
            // labelCoinCount
            // 
            this.labelCoinCount.AutoSize = true;
            this.labelCoinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCoinCount.Location = new System.Drawing.Point(484, 33);
            this.labelCoinCount.Name = "labelCoinCount";
            this.labelCoinCount.Size = new System.Drawing.Size(55, 24);
            this.labelCoinCount.TabIndex = 17;
            this.labelCoinCount.Text = "value";
            // 
            // labelBalance
            // 
            this.labelBalance.AutoSize = true;
            this.labelBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBalance.Location = new System.Drawing.Point(470, 9);
            this.labelBalance.Name = "labelBalance";
            this.labelBalance.Size = new System.Drawing.Size(55, 24);
            this.labelBalance.TabIndex = 18;
            this.labelBalance.Text = "value";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonSell);
            this.panel1.Controls.Add(this.radioButtonBuy);
            this.panel1.Controls.Add(this.textBoxCost);
            this.panel1.Controls.Add(this.textBoxCount);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.buttonBuy);
            this.panel1.Location = new System.Drawing.Point(376, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 218);
            this.panel1.TabIndex = 21;
            // 
            // radioButtonSell
            // 
            this.radioButtonSell.AutoSize = true;
            this.radioButtonSell.Location = new System.Drawing.Point(131, 136);
            this.radioButtonSell.Name = "radioButtonSell";
            this.radioButtonSell.Size = new System.Drawing.Size(71, 19);
            this.radioButtonSell.TabIndex = 20;
            this.radioButtonSell.TabStop = true;
            this.radioButtonSell.Text = "Продать";
            this.radioButtonSell.UseVisualStyleBackColor = true;
            // 
            // radioButtonBuy
            // 
            this.radioButtonBuy.AutoSize = true;
            this.radioButtonBuy.Location = new System.Drawing.Point(14, 136);
            this.radioButtonBuy.Name = "radioButtonBuy";
            this.radioButtonBuy.Size = new System.Drawing.Size(63, 19);
            this.radioButtonBuy.TabIndex = 19;
            this.radioButtonBuy.TabStop = true;
            this.radioButtonBuy.Text = "Купить";
            this.radioButtonBuy.UseVisualStyleBackColor = true;
            this.radioButtonBuy.CheckedChanged += new System.EventHandler(this.radioButtonBuy_CheckedChanged);
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(124, 102);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(105, 23);
            this.textBoxCost.TabIndex = 18;
            this.textBoxCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBoxCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCost_KeyUp);
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(131, 22);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(98, 23);
            this.textBoxCount.TabIndex = 17;
            this.textBoxCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBoxCount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxCount_KeyUp);
            // 
            // labelUpdate
            // 
            this.labelUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUpdate.AutoSize = true;
            this.labelUpdate.Location = new System.Drawing.Point(12, 336);
            this.labelUpdate.Name = "labelUpdate";
            this.labelUpdate.Size = new System.Drawing.Size(143, 15);
            this.labelUpdate.TabIndex = 22;
            this.labelUpdate.Text = "Последнее обновление :";
            // 
            // labelUpdateValue
            // 
            this.labelUpdateValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelUpdateValue.AutoSize = true;
            this.labelUpdateValue.Location = new System.Drawing.Point(161, 337);
            this.labelUpdateValue.Name = "labelUpdateValue";
            this.labelUpdateValue.Size = new System.Drawing.Size(106, 15);
            this.labelUpdateValue.TabIndex = 23;
            this.labelUpdateValue.Text = "99.99.9999 99:99:99";
            // 
            // labelCurrentPrice
            // 
            this.labelCurrentPrice.AutoSize = true;
            this.labelCurrentPrice.Location = new System.Drawing.Point(12, 48);
            this.labelCurrentPrice.Name = "labelCurrentPrice";
            this.labelCurrentPrice.Size = new System.Drawing.Size(41, 15);
            this.labelCurrentPrice.TabIndex = 24;
            this.labelCurrentPrice.Text = "Цена :";
            // 
            // labelCurrentPriceValue
            // 
            this.labelCurrentPriceValue.AutoSize = true;
            this.labelCurrentPriceValue.Location = new System.Drawing.Point(59, 48);
            this.labelCurrentPriceValue.Name = "labelCurrentPriceValue";
            this.labelCurrentPriceValue.Size = new System.Drawing.Size(40, 15);
            this.labelCurrentPriceValue.TabIndex = 24;
            this.labelCurrentPriceValue.Text = "9999 $";
            // 
            // labelHighDay
            // 
            this.labelHighDay.AutoSize = true;
            this.labelHighDay.Location = new System.Drawing.Point(12, 88);
            this.labelHighDay.Name = "labelHighDay";
            this.labelHighDay.Size = new System.Drawing.Size(36, 15);
            this.labelHighDay.TabIndex = 24;
            this.labelHighDay.Text = "Макс";
            // 
            // labelHighDayValue
            // 
            this.labelHighDayValue.AutoSize = true;
            this.labelHighDayValue.Location = new System.Drawing.Point(102, 88);
            this.labelHighDayValue.Name = "labelHighDayValue";
            this.labelHighDayValue.Size = new System.Drawing.Size(40, 15);
            this.labelHighDayValue.TabIndex = 24;
            this.labelHighDayValue.Text = "9999 $";
            // 
            // labelMinDay
            // 
            this.labelMinDay.AutoSize = true;
            this.labelMinDay.Location = new System.Drawing.Point(12, 103);
            this.labelMinDay.Name = "labelMinDay";
            this.labelMinDay.Size = new System.Drawing.Size(32, 15);
            this.labelMinDay.TabIndex = 24;
            this.labelMinDay.Text = "Мин";
            // 
            // labelMinDayValue
            // 
            this.labelMinDayValue.AutoSize = true;
            this.labelMinDayValue.Location = new System.Drawing.Point(102, 103);
            this.labelMinDayValue.Name = "labelMinDayValue";
            this.labelMinDayValue.Size = new System.Drawing.Size(40, 15);
            this.labelMinDayValue.TabIndex = 24;
            this.labelMinDayValue.Text = "9999 $";
            // 
            // labelPriceChangeDayPercent
            // 
            this.labelPriceChangeDayPercent.AutoSize = true;
            this.labelPriceChangeDayPercent.Location = new System.Drawing.Point(12, 133);
            this.labelPriceChangeDayPercent.Name = "labelPriceChangeDayPercent";
            this.labelPriceChangeDayPercent.Size = new System.Drawing.Size(59, 15);
            this.labelPriceChangeDayPercent.TabIndex = 24;
            this.labelPriceChangeDayPercent.Text = "За сутки :";
            // 
            // labelPriceChangeDayPercerntValue
            // 
            this.labelPriceChangeDayPercerntValue.AutoSize = true;
            this.labelPriceChangeDayPercerntValue.Location = new System.Drawing.Point(107, 133);
            this.labelPriceChangeDayPercerntValue.Name = "labelPriceChangeDayPercerntValue";
            this.labelPriceChangeDayPercerntValue.Size = new System.Drawing.Size(35, 15);
            this.labelPriceChangeDayPercerntValue.TabIndex = 24;
            this.labelPriceChangeDayPercerntValue.Text = "999%";
            // 
            // labelPriceChangeHourPercent
            // 
            this.labelPriceChangeHourPercent.AutoSize = true;
            this.labelPriceChangeHourPercent.Location = new System.Drawing.Point(12, 118);
            this.labelPriceChangeHourPercent.Name = "labelPriceChangeHourPercent";
            this.labelPriceChangeHourPercent.Size = new System.Drawing.Size(48, 15);
            this.labelPriceChangeHourPercent.TabIndex = 24;
            this.labelPriceChangeHourPercent.Text = "За час :";
            // 
            // labelPriceChangeHourPercentValue
            // 
            this.labelPriceChangeHourPercentValue.AutoSize = true;
            this.labelPriceChangeHourPercentValue.Location = new System.Drawing.Point(107, 118);
            this.labelPriceChangeHourPercentValue.Name = "labelPriceChangeHourPercentValue";
            this.labelPriceChangeHourPercentValue.Size = new System.Drawing.Size(35, 15);
            this.labelPriceChangeHourPercentValue.TabIndex = 24;
            this.labelPriceChangeHourPercentValue.Text = "999%";
            // 
            // labelPriceChangeTwoWeekPercent
            // 
            this.labelPriceChangeTwoWeekPercent.AutoSize = true;
            this.labelPriceChangeTwoWeekPercent.Location = new System.Drawing.Point(12, 164);
            this.labelPriceChangeTwoWeekPercent.Name = "labelPriceChangeTwoWeekPercent";
            this.labelPriceChangeTwoWeekPercent.Size = new System.Drawing.Size(89, 15);
            this.labelPriceChangeTwoWeekPercent.TabIndex = 24;
            this.labelPriceChangeTwoWeekPercent.Text = "За две недели :";
            // 
            // labelPriceChangeTwoWeekPercentValue
            // 
            this.labelPriceChangeTwoWeekPercentValue.AutoSize = true;
            this.labelPriceChangeTwoWeekPercentValue.Location = new System.Drawing.Point(107, 164);
            this.labelPriceChangeTwoWeekPercentValue.Name = "labelPriceChangeTwoWeekPercentValue";
            this.labelPriceChangeTwoWeekPercentValue.Size = new System.Drawing.Size(35, 15);
            this.labelPriceChangeTwoWeekPercentValue.TabIndex = 24;
            this.labelPriceChangeTwoWeekPercentValue.Text = "999%";
            // 
            // labelPriceChangeWeekPercent
            // 
            this.labelPriceChangeWeekPercent.AutoSize = true;
            this.labelPriceChangeWeekPercent.Location = new System.Drawing.Point(12, 149);
            this.labelPriceChangeWeekPercent.Name = "labelPriceChangeWeekPercent";
            this.labelPriceChangeWeekPercent.Size = new System.Drawing.Size(71, 15);
            this.labelPriceChangeWeekPercent.TabIndex = 24;
            this.labelPriceChangeWeekPercent.Text = "За неделю :";
            // 
            // labelPriceChangeWeekPercentValue
            // 
            this.labelPriceChangeWeekPercentValue.AutoSize = true;
            this.labelPriceChangeWeekPercentValue.Location = new System.Drawing.Point(107, 149);
            this.labelPriceChangeWeekPercentValue.Name = "labelPriceChangeWeekPercentValue";
            this.labelPriceChangeWeekPercentValue.Size = new System.Drawing.Size(35, 15);
            this.labelPriceChangeWeekPercentValue.TabIndex = 24;
            this.labelPriceChangeWeekPercentValue.Text = "999%";
            // 
            // labelPriceChangeMonthPercent
            // 
            this.labelPriceChangeMonthPercent.AutoSize = true;
            this.labelPriceChangeMonthPercent.Location = new System.Drawing.Point(12, 179);
            this.labelPriceChangeMonthPercent.Name = "labelPriceChangeMonthPercent";
            this.labelPriceChangeMonthPercent.Size = new System.Drawing.Size(63, 15);
            this.labelPriceChangeMonthPercent.TabIndex = 24;
            this.labelPriceChangeMonthPercent.Text = "За месяц :";
            // 
            // labelPriceChangeMonthPercentValue
            // 
            this.labelPriceChangeMonthPercentValue.AutoSize = true;
            this.labelPriceChangeMonthPercentValue.Location = new System.Drawing.Point(107, 179);
            this.labelPriceChangeMonthPercentValue.Name = "labelPriceChangeMonthPercentValue";
            this.labelPriceChangeMonthPercentValue.Size = new System.Drawing.Size(35, 15);
            this.labelPriceChangeMonthPercentValue.TabIndex = 24;
            this.labelPriceChangeMonthPercentValue.Text = "999%";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 360);
            this.Controls.Add(this.labelCurrentPriceValue);
            this.Controls.Add(this.labelPriceChangeHourPercentValue);
            this.Controls.Add(this.labelPriceChangeWeekPercentValue);
            this.Controls.Add(this.labelPriceChangeMonthPercentValue);
            this.Controls.Add(this.labelPriceChangeTwoWeekPercentValue);
            this.Controls.Add(this.labelPriceChangeDayPercerntValue);
            this.Controls.Add(this.labelMinDayValue);
            this.Controls.Add(this.labelHighDayValue);
            this.Controls.Add(this.labelPriceChangeHourPercent);
            this.Controls.Add(this.labelPriceChangeWeekPercent);
            this.Controls.Add(this.labelPriceChangeMonthPercent);
            this.Controls.Add(this.labelPriceChangeTwoWeekPercent);
            this.Controls.Add(this.labelPriceChangeDayPercent);
            this.Controls.Add(this.labelMinDay);
            this.Controls.Add(this.labelHighDay);
            this.Controls.Add(this.labelCurrentPrice);
            this.Controls.Add(this.labelUpdateValue);
            this.Controls.Add(this.labelUpdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelCoinCount);
            this.Controls.Add(this.labelBalance);
            this.Controls.Add(this.coinComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ComboBox coinComboBox;
        private Button buttonBuy;
        private Label label12;
        private Label label13;
        private TrackBar trackBar1;
        private Label label14;
        private Label label15;
        private Label labelCoinCount;
        private Label labelBalance;
        private Panel panel1;
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
    }
}