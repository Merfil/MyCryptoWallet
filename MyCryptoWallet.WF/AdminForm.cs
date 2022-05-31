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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(ApiEnum.Coin)))
            {
                coinComboBox.Items.Add(item);
            }
            coinComboBox.SelectedIndex = 0;

            UpdateDGV();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HistoryController historyController = new HistoryController();
            historyController.ChangeValue(coinComboBox.Text, Convert.ToDouble(textBox1.Text));

            UpdateDGV();
        }

        private void UpdateDGV()
        {
            HistoryController historyController = new HistoryController();
            dataGridView1.DataSource = historyController.GetHistories();
            dataGridView2.DataSource = historyController.Wallets;
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
