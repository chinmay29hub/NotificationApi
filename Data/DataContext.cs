using Microsoft.EntityFrameworkCore;

namespace NotificationApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=AMD-082023-0066\\SQLEXPRESS;Database=notificationDB;User Id=chinmay29hub;Password=Database@123;TrustServerCertificate=true");
        }

        public DbSet<NotificationModel> NotificationData { get; set; }
    }
}
