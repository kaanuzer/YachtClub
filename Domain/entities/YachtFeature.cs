namespace Domain.Entities
{
    public class YachtFeature : BaseEntity
    {
        public required string FeatureName { get; set; }
        public int YachtFeatureCategoryId { get; set; }
        public YachtFeatureCategory? YachtFeatureCategory { get; set; }
    }
}
