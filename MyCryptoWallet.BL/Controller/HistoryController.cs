using MyCryptoWallet.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCryptoWallet.BL.Controller
{
    public class HistoryController
    {
        public List<Wallet> Wallets { get; set; } = new List<Wallet>();
        CryptoContext context;

        public HistoryController() 
        {
            context = new CryptoContext();
            Wallets = context.Wallets.ToList();
        }

        public double GetFees(double price, double count)
        { 
            return (count * price) / 1000;
        }

        public List<History> GetHistories()
        {
            return context.Histories.ToList();
        }

        public double GetCoinCount(string coin)
        {
            var wallet = new Wallet();
            try
            {
                wallet = Wallets.Single(w => w.Coin == coin);
            }
            catch (Exception)
            {
                wallet.Coin = coin;
                wallet.Count = 0;
            }
            return wallet.Count;
        }

        public void CreateWallets ()
        {
            var coinsCount = Enum.GetNames(typeof(ApiEnum.Coin)).Length;
            for (int i = 0; i < coinsCount; i++)
            {
                var coin = Enum.GetValues(typeof(ApiEnum.Coin)).GetValue(i)?.ToString();
                var wallet = new Wallet();
                try
                {
                    wallet = Wallets.Single(w => w.Coin == coin);
                }
                catch (Exception)
                {
                    wallet.Coin = coin;
                    wallet.Count = 0;
                    context.Wallets.Add(wallet);
                    Wallets.Add(wallet);
                }
            }
            context.SaveChanges();
        }

        public void ChangeValue(string coinToBuy, string coinToSell, double count, double price, bool isBuying)
        {
            var walletToBuy = Wallets.Single(w => w.Coin == coinToBuy);
            var walletToSell = Wallets.Single(w => w.Coin == coinToSell);
            var fee = Math.Round(GetFees(price, count),2);

            if (isBuying)
            {
                walletToSell.Count -= Math.Round(price * count + fee, 2);
                walletToBuy.Count += Math.Round(count, 2);
            }
            else
            {
                walletToSell.Count -= Math.Round(count, 2);
                walletToBuy.Count += Math.Round(price * count - fee, 2);
            }

            walletToSell.Count = Math.Round(walletToSell.Count, 2);
            walletToBuy.Count = Math.Round(walletToBuy.Count, 2);

            var history = new History(coinToBuy, coinToSell, price, count, fee, isBuying);

            context.Histories.Add(history);
            context.Wallets.Update(walletToBuy);
            context.Wallets.Update(walletToSell);
            context.SaveChanges();
        }

        public void ChangeValue(string coin, double count)
        {
            var wallet = Wallets.Single(w => w.Coin == coin);
            wallet.Count += count;
            Math.Round(wallet.Count, 2);

            context.Update(wallet);
            context.SaveChanges();
        }
    }
}
