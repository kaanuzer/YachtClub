namespace Domain.entities
{
    public class Rental : BaseEntity
    {
        public DateTimeOffset RentalStartDate { get; set; }
        public DateTimeOffset RentalEndDate { get; set; }
        public decimal RentalPrice { get; set; }
        public required string Status { get; set; }
        public string? Description { get; set; }
        public int YachtId { get; set; }
        public required Yacht Yacht { get; set; }
    }
}
