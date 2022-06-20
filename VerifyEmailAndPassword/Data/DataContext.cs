
namespace VerifyEmailAndPassword.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlite("Data source=verifyName.db");
        }

        public DbSet<User> Users => Set<User>();
    }
}
