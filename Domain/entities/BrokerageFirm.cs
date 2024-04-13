namespace Domain.entities
{
    public class BrokerageFirm : BaseEntity
    {
        public required string FirmName { get; set; }
        public required string ContactPerson { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public string? Location { get; set; }
        public List<Yacht>? Yachts { get; set; }
    }
}
