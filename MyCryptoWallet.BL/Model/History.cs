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
        public Coin Coin { get; set; }
        public double Price { get; set; }
        public double Count { get; set; }

        public History() { }
    }
}
