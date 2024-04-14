namespace Domain.Entities
{
    public class ManufacturerModel : BaseEntity
    {
        public string? ModelName { get; set; }

        public DateTimeOffset ModelStartDate { get; set; }

        public DateTimeOffset ModelEndDate { get; set; }

        public int YachtCategoryId { get; set; }

        public YachtCategory? YachtCategory { get; set; }

        public int ManufacturerId { get; set; }

        public Manufacturer? Manufacturer { get; set; }
    }
}
