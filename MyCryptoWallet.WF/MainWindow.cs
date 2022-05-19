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
    }
}