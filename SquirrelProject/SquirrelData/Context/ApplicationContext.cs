using Microsoft.EntityFrameworkCore;
using SquirrelDomain.Entities;

namespace SquirrelData.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }

        public DbSet<Account> AccountDomains { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(p =>
            {
                p.ToTable("Accounts");
                p.HasKey(x => x.AccountId);
                p.Property(x => x.AccountId).IsRequired().ValueGeneratedOnAdd();
                p.Property(x => x.UserName).HasColumnType("VARCHAR(30)").IsRequired();
                p.Property(x => x.Password).HasColumnType("VARCHAR(30)").IsRequired();
                p.Property(x => x.RememberMe).HasColumnType("BIT");
            });
        }
    }
}

