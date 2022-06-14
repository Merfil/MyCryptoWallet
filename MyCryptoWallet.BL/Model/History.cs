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
        public string CoinId { get; set; }
        public string CoinName { get; set; }
        public double Price { get; set; }
        public double Count { get; set; }
        public double Fees { get; set; }
        public bool IsBuing { get; set; }
        public History() { }

        public History(string coinId, string coinName, double price, double count, double fees, bool isBuing)
        {
            DateTime = DateTime.Now;
            CoinId = coinId;
            CoinName = coinName;
            Price = price;
            Count = count;
            Fees = fees;
            IsBuing = isBuing;
        }
    }
}
