using System.ComponentModel.DataAnnotations;

namespace CouponAPI.Data
{
    public class Coupon
    {
        [Key]
        public int CouponID { get; set; }
        
        [Required]
        public string? CouponName { get; set; }
        
        [Required]
        public double DiscountAmount { get; set; }
        public double MinAmount { get; set;}

    }
}
