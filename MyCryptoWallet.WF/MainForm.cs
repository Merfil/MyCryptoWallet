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

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            HistoryController historyController = new HistoryController();
            ApiController apiController = new ApiController();

            Data.Coins = apiController.GetResponse();
            historyController.CreateWallets();
        }

        private void OpenForm(Form form, string text)
        {
            labelHeader.Text = text;
            panelMain.Controls.Clear();
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(form);
            form.Show();
        }

        private void buttonWallet_Click(object sender, EventArgs e)
        {
            var walletFotm = new WalletForm();
            OpenForm(walletFotm, (sender as Button).Text);
            PanelNav(sender as Button);
        }

        private void buttonCoins_Click(object sender, EventArgs e)
        {
            var infoForm = new InfoForm();
            OpenForm(infoForm, (sender as Button).Text);
            PanelNav(sender as Button);
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            var adminForm = new DepositForm();
            OpenForm(adminForm, (sender as Button).Text);
            PanelNav(sender as Button);
        }

        private void PanelNav(Button sender)
        {
            panelNav.Height = sender.Height;
            panelNav.Top = sender.Top;
            panelNav.Left = sender.Left;

            foreach (var item in panelNavigation.Controls)
            {
                if (item is Button)
                {
                    (item as Button).BackColor = Color.FromArgb(20, 30, 54);
                }
            }

            sender.BackColor = Color.FromArgb(46, 51, 73);
        }
    }
}