using Microsoft.EntityFrameworkCore;

namespace SatoshisCrypto.Models
{
  public class SatoshisCryptoContext : DbContext

    {
        public SatoshisCryptoContext(DbContextOptions<SatoshisCryptoContext> options)
            : base(options)
        {
        }
        public DbSet<BtcComment> BtcComments { get; set; }
        public DbSet<EthComment> EthComments { get; set; }

        public DbSet<AdaComment> AdaComments { get; set; }
    }
}