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

        public List<History> GetHistories(string coin)
        {
            var buyList = (context.Histories.Where(c => c.CoinId == coin).ToList());
            return buyList;
        }

        public double GetCoinCount(string coin)
        {
            var wallet = Wallets.Single(w => w.CoinId == coin);
            return wallet.Count;
        }

        public void CreateWallets ()
        {
            var coinsCount = Data.Coins.Count();
            for (int i = 0; i < coinsCount; i++)
            {
                var coin = Data.Coins[i].Id.ToString();
                var wallet = new Wallet();
                try
                {
                    wallet = Wallets.Single(w => w.CoinId == coin);
                }
                catch (Exception)
                {
                    wallet.CoinName = Data.Coins[i].Name;
                    wallet.CoinId = coin;
                    wallet.Count = 0;
                    context.Wallets.Add(wallet);
                    Wallets.Add(wallet);
                }
            }
            context.SaveChanges();
        }

        public void ChangeValue(string coinId, string coinName, double count, double price, bool isBuying)
        {
            var wallet = Wallets.Single(w => w.CoinId == coinId);
            var tetherWallet = Wallets.Single(w => w.CoinId == "tether");
            var fee = Math.Round(GetFees(price, count),2);

            if (isBuying)
            {
                tetherWallet.Count -= price * count + fee;
                wallet.Count += count;
            }
            else
            {
                wallet.Count -= count;
                tetherWallet.Count += price * count - fee;
            }

            wallet.Count = Math.Round(wallet.Count, 2);
            tetherWallet.Count = Math.Round(tetherWallet.Count, 2);

            var history = new History(coinId, coinName, price, count, fee, isBuying);

            context.Histories.Add(history);
            context.Wallets.Update(wallet);
            context.Wallets.Update(tetherWallet);
            context.SaveChanges();
        }

        public void ChangeValue(string coin, double count)
        {
            var wallet = Wallets.Single(w => w.CoinId == coin);
            wallet.Count += count;
            Math.Round(wallet.Count, 2);

            context.Update(wallet);
            context.SaveChanges();
        }
    }
}
