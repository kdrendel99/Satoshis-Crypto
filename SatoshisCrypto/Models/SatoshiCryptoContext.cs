using Microsoft.EntityFrameworkCore;

namespace SatoshisCrypto.Models
{
  public class SatoshisCryptoContext : DbContext

    {
        public SatoshisCryptoContext(DbContextOptions<SatoshisCryptoContext> options)
            : base(options)
        {
        }
        public DbSet<Comment> Comments { get; set; }
    }
}