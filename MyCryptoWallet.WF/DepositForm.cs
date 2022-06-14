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
    public partial class DepositForm : Form
    {
        public DepositForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            foreach (var coin in Data.Coins)
            {
                coinComboBox.Items.Add(coin.Name);
            }
            coinComboBox.SelectedIndex = 0;

            HistoryController historyController = new HistoryController();
            dataGridViewWallets.DataSource = historyController.Wallets;
            dataGridViewWallets.Columns[0].Visible = false;
            dataGridViewWallets.Columns[1].HeaderText = "Название";
            dataGridViewWallets.Columns[2].Visible = false;
            dataGridViewWallets.Columns[3].HeaderText = "Количество";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HistoryController historyController = new HistoryController();
            historyController.ChangeValue(Data.Coins[coinComboBox.SelectedIndex].Id, Convert.ToDouble(textBox1.Text));

            dataGridViewWallets.DataSource = historyController.Wallets;
            textBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var str = (sender as TextBox).Text;
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
                if (number != ',' || str.Length == 0 || str.Contains(','))
                    e.Handled = true;
        }
    }
}
