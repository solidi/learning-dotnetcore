using Microsoft.EntityFrameworkCore;
namespace EFCoreWebDemo
{
    public class EFCoreWebDemoContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=EFCoreWebDemo;MultipleActiveResultSets=true;User Id=sa;password=reallyStrongPwd123;");
        }
    }
}