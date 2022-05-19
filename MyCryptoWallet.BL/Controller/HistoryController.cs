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
        public HistoryController() { }

        public List<History> GetHistories()
        {
            using (CryptoContext context = new CryptoContext())
            {
                return context.Histories.ToList();
            }
        }

        public void AddHistory(Coin coin, double price, double count)
        {
            using (CryptoContext context = new CryptoContext())
            {
                var history = new History();
                history.DateTime = DateTime.UtcNow;
                history.Price = price;
                history.Coin = coin;
                history.Count = count;

                context.Histories.Add(history);
                context.SaveChanges();
            }
        }
    }
}
