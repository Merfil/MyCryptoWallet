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
            foreach (var item in Enum.GetValues(typeof(ApiEnum.Coin)))
            {
                coinComboBox.Items.Add(item);
            }
            coinComboBox.SelectedIndex = 0;
        }

        private async void coinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var coin = coinComboBox.Text;
            var histories = new List<History>();
            if (coin != "All")
                histories = historyController.GetHistories(coin);
            else
                histories = historyController.GetHistories();
            dataGridView1.DataSource = histories;

            var buyingHistory = histories.Where(w => w.IsBuing == true);
            double buyingSum = 0;
            foreach (var item in buyingHistory)
            {
                buyingSum += item.Price * item.Count + item.Fees;
            }
            spentMoney.Text = buyingSum.ToString();

            var sellingHistory = histories.Where(w => w.IsBuing == false);
            double sellingSum = 0;
            foreach (var item in sellingHistory)
            {
                sellingSum += item.Price * item.Count - item.Fees;
            }
            earnedMoney.Text = sellingSum.ToString();

            //coinValue = 
        }
    }
}
