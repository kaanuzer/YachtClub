namespace Domain.Entities
{
    public class YachtImage : BaseEntity
    {
        public int YachtId { get; set; }
        public required string ImageUrl { get; set; }
        public Yacht? Yacht { get; set; }
    }
}
