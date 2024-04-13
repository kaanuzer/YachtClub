namespace Domain.entities
{
    public class Yacht : BaseEntity
    {
        public string? YachtName { get; set; }
        public int Year { get; set; }
        public double Length { get; set; }
        public decimal Price { get; set; }
        public required string Description { get; set; }
        public string? Condition { get; set; }
        public string? Location { get; set; }
        public string? Fuel { get; set; }
        public string? HullMaterial { get; set; }
        public int? Cabin { get; set; }
        public int? Heads { get; set; }
        public int? MaxSpeed { get; set; }
        public int? CruisingSpeed { get; set; }
        public int BrokerageFirmId { get; set; }
        public BrokerageFirm? BrokerageFirm { get; set; }
        public int ManufacturerId { get; set; }
        public Manufacturer? Manufacturer { get; set; }
        public ICollection<YachtImage>? YachtImages { get; set; }
        public int YachtCategoryId { get; set; }
        public required YachtCategory YachtCategory { get; set; }
        public ICollection<YachtFeatureCategory>? YachtFeatureCategories { get; set; }
        public ICollection<Comment>? Comments { get; set; }
        public ICollection<Offer>? Offers { get; set; }
        public ICollection<Rental>? Rentals { get; set; }
    }
}
