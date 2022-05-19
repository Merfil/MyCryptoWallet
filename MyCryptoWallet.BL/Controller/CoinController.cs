﻿using MyCryptoWallet.BL.Model;

namespace MyCryptoWallet.BL.Controller
{
    public class CoinController
    {
        public CoinController() { }

        public List<Coin> GetCoins()
        {
            using (CryptoContext context = new CryptoContext())
            {
                return context.Coins.ToList();
            }
        }

        public Coin GetCoin(string ticker)
        {
            using (CryptoContext context = new CryptoContext())
            {
                return context.Coins.Single(c => c.Ticker == ticker);
            }
        }

        public void AddCoin(string ticker, string name)
        {
            using (CryptoContext context = new CryptoContext())
            {
                var coin = new Coin();
                coin.Ticker = ticker;
                coin.Name = name;
                context.Coins.Add(coin);
                context.SaveChanges();
            }
        }
    }
}
