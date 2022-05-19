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
    public partial class AddMoneyForm : Form
    {
        public AddMoneyForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var walletController = new WalletController();
            var coinController = new CoinController();
            var coin = coinController.GetCoin(comboBox1.Text);
            walletController.AddWallet(coin.Id, Convert.ToDouble(textBox1.Text));
            Close();
        }

        private void AddMoneyForm_Load(object sender, EventArgs e)
        {
            var coinController = new CoinController();
            List<Coin> coins = coinController.GetCoins();
            foreach (Coin coin in coins)
            {
                comboBox1.Items.Add(coin);
            }
        }
    }
}
