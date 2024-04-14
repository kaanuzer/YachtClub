namespace Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string? CommentType { get; set; }
        public required string CommentText { get; set; }
        public int Points { get; set; }
        public int YachtId { get; set; }
        public required Yacht Yacht { get; set; }
    }
}
