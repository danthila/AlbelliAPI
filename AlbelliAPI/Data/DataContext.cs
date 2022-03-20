
namespace AlbelliAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order_Product>()
                .HasOne(b => b.OrderInfomation)
                .WithMany(ba => ba.Order_Products)
                .HasForeignKey(bi => bi.OrderId);

            modelBuilder.Entity<Order_Product>()
              .HasOne(b => b.ProdcutType)
              .WithMany(ba => ba.Order_Products)
              .HasForeignKey(bi => bi.ProductId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<OrderInfomation> OrderInfomation { get; set; }

        public DbSet<ProdcutType> ProdcutTypes { get; set; }

        public DbSet<Order_Product> Order_Products { get; set; }

    }
}
 