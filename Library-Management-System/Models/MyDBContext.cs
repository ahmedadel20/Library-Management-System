using Microsoft.EntityFrameworkCore;

namespace Library_Management_System.Models
{
    public class MyDBContext :DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=LibraryManagementSystem;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transaction>()
                .HasKey(t => new { t.BookId, t.CustomerId }); // Composite Key

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Book)
                .WithMany(b => b.Transactions)
                .HasForeignKey(t => t.BookId);

            modelBuilder.Entity<Transaction>()
                .HasOne(t => t.Customer)
                .WithMany(a => a.Transactions)
                .HasForeignKey(t => t.CustomerId);
        }
    }
}
