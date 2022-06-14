using MyCryptoWallet.BL.Controller;
using MyCryptoWallet.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCryptoWallet.WF
{
    public partial class WalletForm : Form
    {
        HistoryController historyController = new HistoryController();

        public WalletForm()
        {
            InitializeComponent();
        }

        private void WalletForm_Load(object sender, EventArgs e)
        {
            coinComboBox.Items.Add("All");
            foreach (var coin in Data.Coins)
            {
                //if (coin.Id != "tether")
                    coinComboBox.Items.Add(coin.Name);
            }
            coinComboBox.SelectedIndex = 0;

            dataGridViewWallets.DataSource = historyController.Wallets;
            DataGridColumnStyle();

            var backColor = Color.FromKnownColor(KnownColor.Control);
            var gridColor = Color.Black;
            var cellBackColor = Color.LightGray;
        }

        private void coinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var histories = new List<History>();
            //var coin = Data.Coins[coinComboBox.SelectedIndex];
            var coin = new Coin();

            if (coinComboBox.Text != "All")
            {
                coin = Data.Coins[coinComboBox.SelectedIndex - 1];
                histories = historyController.GetHistories(coin.Id);
            }
            else
            {
                histories = historyController.GetHistories();
            }
            dataGridViewHistory.DataSource = histories;

            labelSpentMoneyValue.Text = CoinValue(histories, true).ToString("#,0.##") + " $";
            labelEarnedMoneyValue.Text = CoinValue(histories, false).ToString("#,0.##") + " $";

            if (coinComboBox.Text != "All")
            {
                labelAmountInCountValue.Text = MoneyFromCoin(coin).ToString("#,0.##") + " $";
                labelTotalValue.Text = (CoinValue(histories, false) + MoneyFromCoin(coin) - CoinValue(histories, true)).ToString("#,0.##") + " $";
            }
            else
            {
                labelAmountInCountValue.Text = MoneyFromCoin().ToString("#,0.##") + " $";
                labelTotalValue.Text = (CoinValue(histories, false) + MoneyFromCoin() - CoinValue(histories, true)).ToString("#,0.##") + " $";
            }
        }

        private double CoinValue(List<History> histories, bool isBuing)
        {
            var history = histories.Where(w => w.IsBuing == isBuing);
            double value = 0;
            foreach (var item in history)
            {
                if(isBuing)
                    value += item.Price * item.Count + item.Fees;
                else
                    value += item.Price * item.Count - item.Fees;
            }
            if (isBuing)
                return value;
            else
                return value;
        }

        private double MoneyFromCoin()
        {
            double sum = 0;
            foreach (var coin in Data.Coins)
            {
                var wallet = historyController.Wallets.Single(w => w.CoinId == coin.Id);
                if (wallet.CoinId == "tether")
                    break;
                var price = coin.CurrentPrice * wallet.Count - historyController.GetFees(coin.CurrentPrice, wallet.Count);
                sum += price;
            }
            return sum;
        }

        private double MoneyFromCoin(Coin coin)
        {
            var wallet = historyController.Wallets.Single(w => w.CoinId == coin.Id);
            return (coin.CurrentPrice * wallet.Count - historyController.GetFees(coin.CurrentPrice, wallet.Count));
        }

        private void DataGridColumnStyle()
        {
            dataGridViewWallets.Columns[0].Visible = false;
            dataGridViewWallets.Columns[1].HeaderText = "Название";
            dataGridViewWallets.Columns[2].Visible = false;
            dataGridViewWallets.Columns[3].HeaderText = "Количество";

            dataGridViewHistory.Columns[0].Visible = false;
            dataGridViewHistory.Columns[1].HeaderText = "Дата и время";
            dataGridViewHistory.Columns[2].Visible = false;
            dataGridViewHistory.Columns[3].HeaderText = "Валюта";
            dataGridViewHistory.Columns[4].HeaderText = "Цена";
            dataGridViewHistory.Columns[5].HeaderText = "Количество";
            dataGridViewHistory.Columns[6].HeaderText = "Комиссия";
            dataGridViewHistory.Columns[7].HeaderText = "Покупка";
        }
    }
}
