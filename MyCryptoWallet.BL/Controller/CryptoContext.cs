using Microsoft.EntityFrameworkCore;
using MyCryptoWallet.BL.Model;

namespace MyCryptoWallet.BL.Controller
{
    public class CryptoContext : DbContext
    {
        public DbSet<Coin> Coins { get; set; }
        public DbSet<History> Histories { get; set; }
        public DbSet<Wallet> Wallets{ get; set; }

        public CryptoContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=CryptoWallet.db");
        }
    }
}
