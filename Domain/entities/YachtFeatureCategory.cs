namespace Domain.entities
{
    public class YachtFeatureCategory : BaseEntity
    {
        public string? FeatureCategoryName { get; set; }
        public ICollection<YachtFeature>? YachtFeatures { get; set; }
        public int YachtId { get; set; }
        public Yacht? Yacht { get; set; }
    }
}
