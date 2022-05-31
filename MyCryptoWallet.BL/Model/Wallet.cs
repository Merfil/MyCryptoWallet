namespace MyCryptoWallet.BL.Model
{
    public class Wallet
    {
        public int Id { get; set; }
        public string Coin { get; set; }
        public double Count { get; set; }

        public Wallet() { }
    }
}
