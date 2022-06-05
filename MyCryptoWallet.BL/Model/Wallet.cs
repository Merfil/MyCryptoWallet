namespace MyCryptoWallet.BL.Model
{
    public class Wallet
    {
        public int Id { get; set; }
        public string CoinName { get; set; }
        public string CoinId { get; set; }
        public double Count { get; set; }

        public Wallet() { }
    }
}
