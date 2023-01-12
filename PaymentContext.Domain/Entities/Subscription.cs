namespace PaymentContext.Domain.Entities
{
    public class Subscription
    {
        public Subscription(bool active, DateTime createDate, DateTime lastUpdateDate, DateTime? expireDate, List<Payment> payments)
        {
            Active = active;
            CreateDate = DateTime.Now;
            LastUpdateDate = lastUpdateDate;
            ExpireDate = expireDate;
            Payments = payments;
        }

        public bool Active { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public List<Payment> Payments { get; set; }
    }
}
