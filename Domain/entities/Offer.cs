namespace Domain.Entities
{
    public class Offer : BaseEntity
    {
        public decimal OfferPrice { get; set; }
        public string? OfferDescription { get; set; }
        public required string OfferType { get; set; }
        public string? Status { get; set; }
        public int YachtId { get; set; }
        public required Yacht Yacht { get; set; }
    }
}
