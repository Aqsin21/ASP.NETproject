namespace Domain.Entities
{ 
    public class BlogPost : ICreateEntity
    {

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }

        public string? ImagePath { get; set; }
        public int CategoryId { get; set; }
        public DateTime? PublishDate { get; set; }
        public int? PublisherId { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? LastModifiedAt { get; set; }
        public int? LastModifiedBy { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? DeletedBy { get; set; }


    }
}

