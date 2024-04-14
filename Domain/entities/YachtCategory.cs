namespace Domain.Entities
{
    public class YachtCategory : BaseEntity
    {
        public required string CategoryName { get; set; }
        public ICollection<Yacht>? Yachts { get; set; }
        public ICollection<ManufacturerModel>? manufacturerModels { get; set; }
    }
}
