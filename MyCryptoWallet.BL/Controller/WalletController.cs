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

        public void AddWallet(Coin coin, double count)
        {
            using (CryptoContext context = new CryptoContext())
            {
                var wallet = new Wallet();
                wallet.Coin = coin;
                wallet.Count = count;

                context.Wallets.Add(wallet);
                context.SaveChanges();
            }
        }
    }
}
