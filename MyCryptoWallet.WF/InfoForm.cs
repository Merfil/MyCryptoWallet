using MyCryptoWallet.BL.Controller;
using MyCryptoWallet.BL.Model;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;

namespace MyCryptoWallet.WF
{
    public partial class InfoForm : Form
    {
        HistoryController historyController = new HistoryController();

        public InfoForm()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(ApiEnum.Coin)))
            {
                coinComboBox.Items.Add(item);
            }

            foreach (var item in Enum.GetValues(typeof(ApiEnum.Currency)))
            {
                currencyComboBox.Items.Add(item);
            }
            coinComboBox.SelectedIndex = 0;
            currencyComboBox.SelectedIndex = 0;

            labelBalance.Text = historyController.GetCoinCount("tether").ToString() + " $";

            radioButtonBuy.Checked = true;
        }

        private void coinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coinComboBox.SelectedIndex != -1 && currencyComboBox.SelectedIndex != -1)
            {
                ApiEnum.Coin coin = (ApiEnum.Coin)coinComboBox.SelectedItem;
                ApiEnum.Currency currency = (ApiEnum.Currency)currencyComboBox.SelectedItem;
                ApiController apiController = new ApiController(coin, currency);
                string[] a = apiController.GetInfo();
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[a.Length-1] != null)
                    {
                        if (a[i].Contains("usd"))
                        {
                            a[i] = a[i].Replace("usd", "$");
                        }
                        if (a[i].Contains("rub"))
                        {
                            a[i] = a[i].Replace("rub", "���.");
                        }
                        (Controls["label" + (i + 1)] as Label).Text = a[i];
                    }
                    else
                    {
                        (Controls["label" + (i + 1)] as Label).Text = "null";
                    }
                }
                labelCoinCount.Text = historyController.GetCoinCount(coinComboBox.Text).ToString();
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            var buingCoin = coinComboBox.Text;
            var sellingCoin = "tether";
            var count = Convert.ToDouble(textBoxCount.Text);
            var price = Convert.ToDouble(label1.Text.Split(" ")[0]);
            var cost = price * count + historyController.GetFees(price, count);

            if (radioButtonBuy.Checked && Convert.ToDouble(labelBalance.Text.Split(" ")[0]) >= cost)
                historyController.ChangeValue(buingCoin, sellingCoin, count, price, true);
            if (!radioButtonBuy.Checked && Convert.ToDouble(labelCoinCount.Text) >= count )
                historyController.ChangeValue(sellingCoin, buingCoin, count, price, false);

            labelCoinCount.Text = historyController.GetCoinCount(coinComboBox.Text).ToString();
            labelBalance.Text = historyController.GetCoinCount("tether").ToString() + " $";
        }

        private void textBoxCount_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxCount.Text!="")
            {
                var price = Convert.ToDouble(label1.Text.Split(" ")[0]);
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
                var price = Convert.ToDouble(label1.Text.Split(" ")[0]);
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
                buttonBuy.Text = "������";
            else
                buttonBuy.Text = "�������";

            textBoxCost.Text = "";
            textBoxCount.Text = "";
        }
    }
}