using MyCryptoWallet.BL.Controller;
using MyCryptoWallet.BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCryptoWallet.WF
{
    public partial class MainForm : Form
    {

        #region Drag 'n Drop
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();
        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        #endregion
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCoins_Click(object sender, EventArgs e)
        {
            labelHeader.Text = buttonCoins.Text;
            panelMain.Controls.Clear();
            InfoForm infoForm = new InfoForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            infoForm.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(infoForm);
            infoForm.Show();
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            labelHeader.Text = buttonAdmin.Text;
            panelMain.Controls.Clear();
            AdminForm adminForm = new AdminForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            adminForm.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(adminForm);
            adminForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HistoryController historyController = new HistoryController();
            historyController.CreateWallets();

            ApiController apiController = new ApiController();
            Data.Coins = apiController.GetResponse();
        }

        private void buttonWallet_Click(object sender, EventArgs e)
        {
            labelHeader.Text = (sender as Button).Text;
            panelMain.Controls.Clear();
            WalletForm walletForm = new WalletForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            walletForm.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(walletForm);
            walletForm.Show();
        }
    }

    static class Data
    {
        public static Coin[]? Coins { get; set; }
    }
}
