namespace Domain.Entities
{
    public class Project:ICreateEntity
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string ImagePath { get; set; }
        public required string Url { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }
    }
}
