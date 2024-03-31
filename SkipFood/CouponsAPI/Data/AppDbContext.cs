using Microsoft.EntityFrameworkCore;

namespace CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Coupon> coupons { get; set; }
            
    }
}
