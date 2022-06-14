using MyCryptoWallet.BL.Controller;
using MyCryptoWallet.BL.Model;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace MyCryptoWallet.WF
{
    public partial class InfoForm : Form
    {
        HistoryController historyController = new HistoryController();
        Chart chart = new Chart();

        public InfoForm()
        {
            InitializeComponent();
        }

        private void AddChart(Color backGround, Color lineColor, Color seriesColor, int borderWidth)
        {
            panelChart.Controls.Clear();
            chart.ChartAreas.Clear();
            chart.Series.Clear();

            panelChart.Controls.Add(chart);
            ChartArea chartArea1 = new ChartArea();
            ((System.ComponentModel.ISupportInitialize)(chart)).BeginInit();

            chartArea1.Name = "ChartArea1";
            chartArea1.BackColor = backGround;
            chartArea1.Axes[0].MajorGrid.LineColor = lineColor;
            chartArea1.Axes[1].MajorGrid.LineColor = lineColor;
            chart.ChartAreas.Add(chartArea1);
            chart.Name = "chart1";
            chart.Dock = DockStyle.Fill;
            chart.BackColor = backGround;
            chart.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.FromArgb(158, 161, 176);
            chart.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.FromArgb(158, 161, 176);
            chart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Nirmala UI", 10);
            chart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Nirmala UI", 10);

            var sparkline = Data.Coins[coinComboBox.SelectedIndex].SparklineIn7d.Price;
            var interval = sparkline.Count / 7;
            chart.ChartAreas[0].AxisX.Interval = interval;
            var today = DateTime.UtcNow.Date;
            for (int i = 0; i < 7; i++)
            {
                var substractDay = 6-i;
                chart.ChartAreas[0].AxisX.CustomLabels.Add(i * interval, i * interval + interval, today.Subtract(new TimeSpan(substractDay, 0, 0, 0)).ToString("d.MM"));
            }

            Series series = new Series();
            series.ChartType = SeriesChartType.Spline;
            series.BorderWidth = borderWidth;
            series.Color = seriesColor;

            var count = sparkline.Count;
            double min = double.MaxValue;
            for (int i = 0; i < count; i++)
            {
                var price = sparkline[i];
                if(min>price)
                    min = price;
                series.Points.AddXY(i+1, price);
            }
            chartArea1.Axes[1].Minimum = Convert.ToDouble(min.ToString("0.##"));

            chart.Series.Add(series);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            foreach (var coin in Data.Coins)
            {
                //if (coin.Id != "tether")
                    coinComboBox.Items.Add(coin.Name);
            }

            coinComboBox.SelectedIndex = 0;
            labelBalanceValue.Text = historyController.GetCoinCount("tether").ToString() + " $";
            radioButtonBuy.Checked = true;
            textBoxCost.Text = "0";
            textBoxCount.Text = "0";
        }

        private void coinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var coinId = Data.Coins[coinComboBox.SelectedIndex].Id;
            var coin = Data.Coins.Single(c => c.Id == coinId);

            labelUpdateValue.Text = coin.LastUpdated.ToString();
            labelCurrentPriceValue.Text = coin.CurrentPrice.ToString("#,0.##") + " $";
            labelHighDayValue.Text = coin.High24h.ToString("#,0.##") + " $";
            labelMinDayValue.Text = coin.Low24h.ToString("#,0.##") + " $";
            labelPriceChangeHourPercentValue.Text = coin.PriceChangePercentage1hInCurrency.ToString("#,0.##") + " %";
            labelPriceChangeDayPercerntValue.Text = coin.PriceChangePercentage24h.ToString("#,0.##") + " %";
            labelPriceChangeWeekPercentValue.Text = coin.PriceChangePercentage7dInCurrency.ToString("#,0.##") + " %";
            labelPriceChangeTwoWeekPercentValue.Text = coin.PriceChangePercentage7dInCurrency.ToString("#,0.##") + " %";
            labelPriceChangeMonthPercentValue.Text = coin.PriceChangePercentage30dInCurrency.ToString("#,0.##") + " %";
            labelCoinCountValue.Text = historyController.GetCoinCount(coinId).ToString();

            Color backGround = Color.FromArgb(37, 42, 64);
            Color lineColor = Color.FromArgb(46, 51, 73);
            Color seriesColor = Color.FromArgb(65, 140, 241);
            var borderWidth = 2;

            AddChart(backGround, lineColor, seriesColor, borderWidth);
            textBoxCount_KeyUp(null, null);
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            if (textBoxCost.Text == "" || textBoxCount.Text == "")
                return;

            var coinId = Data.Coins[coinComboBox.SelectedIndex].Id;
            var buyingCount = Convert.ToDouble(textBoxCount.Text);
            var price = Data.Coins[coinComboBox.SelectedIndex].CurrentPrice;
            var cost = price * buyingCount + historyController.GetFees(price, buyingCount);
            var balance = historyController.GetCoinCount("tether");
            var coinCount = historyController.GetCoinCount(coinId);
            var coinName = coinComboBox.Text;

            if (radioButtonBuy.Checked && balance >= cost)
                historyController.ChangeValue(coinId, coinName, buyingCount, price, true);
            if (!radioButtonBuy.Checked && coinCount >= buyingCount)
                historyController.ChangeValue(coinId, coinName, buyingCount, price, false);

            labelCoinCountValue.Text = historyController.GetCoinCount(coinId).ToString();
            labelBalanceValue.Text = historyController.GetCoinCount("tether").ToString() + " $";
        }

        private void textBoxCount_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxCount.Text!="")
            {
                var price = Data.Coins[coinComboBox.SelectedIndex].CurrentPrice;
                var count = Convert.ToDouble(textBoxCount.Text);
                var fee = historyController.GetFees(price,count);

                if (radioButtonBuy.Checked)
                    textBoxCost.Text = Math.Round(price * count + fee,2).ToString();
                if (!radioButtonBuy.Checked)
                    textBoxCost.Text = Math.Round(price * count - fee, 2).ToString();
            }
        }

        private void textBoxCost_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxCost.Text!="")
            {
                var price = Data.Coins[coinComboBox.SelectedIndex].CurrentPrice;
                var cost = Convert.ToDouble(textBoxCost.Text);
                var count = (1000 * cost) / 1001 / price;
                textBoxCount.Text = Math.Round(count,2).ToString();
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var str = (sender as TextBox).Text;
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
                if (number != ',' || str.Length == 0 || str.Contains(','))
                    e.Handled = true;
        }

        private void radioButtonBuy_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonBuy.Checked)
                buttonBuy.Text = "Купить";
            else
                buttonBuy.Text = "Продать";

            textBoxCost.Text = "";
            textBoxCount_KeyUp(null, null);
        }
    }
}