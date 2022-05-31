namespace MyCryptoWallet.BL.Model
{
    public class ApiEnum
    {
        public enum Command
        {
            current_price,
            low_24h,
            high_24h,
            price_change_24h_in_currency,
            price_change_percentage_1h_in_currency,
            price_change_percentage_24h_in_currency,
            price_change_percentage_7d_in_currency,
            price_change_percentage_14d_in_currency,
            price_change_percentage_30d_in_currency,
            price_change_percentage_60d_in_currency,
            last_updated
        }

        public enum Currency
        {
            usd,
            btc,
            eth,
            rub
        }

        public enum Coin
        {
            bitcoin,
            ethereum,
            tether,
            binancecoin,
            cardano,
            solana,
            dogecoin,
            polkadot,
            litecoin,
            tron
        }
    }
}
