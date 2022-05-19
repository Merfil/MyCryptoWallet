using MyCryptoWallet.BL.Controller;
using MyCryptoWallet.BL.Model;

namespace MyCryptoWallet.WF
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            var coinController = new CoinController();
            List<Coin> coins = coinController.GetCoins();
            foreach (Coin coin in coins)
            {
                coinComboBox.Items.Add(coin);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addCoinForm = new AddCoinForm();
            addCoinForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var addMoneyForm = new AddMoneyForm();
            addMoneyForm.ShowDialog();
        }

        private void coinComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using(CryptoContext context = new CryptoContext())
            {
                var ticket = coinComboBox.Text;
                WalletController walletController = new WalletController();
                var wallet = walletController.GetWallet(ticket);
                label2.Text=wallet.Count.ToString();
            }
        }
    }
}