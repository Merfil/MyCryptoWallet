namespace MyCryptoWallet.BL.Model
{
    public class Coin
    {
        public int Id { get; set; }
        public string Ticker { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Coin() { }
        public override string ToString()
        {
            return Ticker;
        }
    }
}
