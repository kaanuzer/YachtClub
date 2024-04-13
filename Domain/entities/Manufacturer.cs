namespace Domain.entities
{
    public class Manufacturer : BaseEntity
    {
        public required string ManufacturerName { get; set; }

        public Yacht? Yacht { get; set; }

        public ICollection<ManufacturerModel>? ManufacturerModels { get; set; }
    }
}
