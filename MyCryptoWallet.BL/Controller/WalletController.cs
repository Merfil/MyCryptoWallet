using MyCryptoWallet.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCryptoWallet.BL.Controller
{
    public class WalletController
    {
        public WalletController() { }

        public List<Wallet> GetWallets()
        {
            using (CryptoContext context = new CryptoContext())
            {
                return context.Wallets.ToList();
            }
        }
        public Wallet GetWallet(string ticker)
        {
            using (CryptoContext context = new CryptoContext())
            {
                CoinController coinController = new CoinController();
                var coin = coinController.GetCoin(ticker);
                return context.Wallets.Single(t => t.Coin == coin);
            }
        }

        public void AddWallet(int coinId, double count)
        {
            using (CryptoContext context = new CryptoContext())
            {
                var wallet = new Wallet();
                wallet.Coin = context.Coins.Single(c=>c.Id==coinId);
                wallet.Count = count;

                context.Wallets.Add(wallet);
                context.SaveChanges();
            }
        }
    }
}
