using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCryptoWallet.BL.Model
{
    public class History
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public string BuingCoin { get; set; }
        public string SellingCoin { get; set; }
        public double Price { get; set; }
        public double Count { get; set; }
        public double Fees { get; set; }
        public bool IsBuing { get; set; }
        public History() { }

        public History(string buingCoin, string sellingCoin, double price, double count, double fees, bool isBuying)
        {
            DateTime = DateTime.Now;
            BuingCoin = buingCoin;
            SellingCoin = sellingCoin;
            Price = price;
            Count = count;
            Fees = fees;
            IsBuing = isBuying;
        }
    }
}
