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
    }
}
