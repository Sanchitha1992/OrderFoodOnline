namespace CouponAPI.Model.Dto
{
    public class CouponResponseDto
    {
        public int CouponId { get; set; }
        public string? CouponName { get; set; }
        public double CouponAmount { get; set; }
        public double MinAmount { get; set; }


    }
}
