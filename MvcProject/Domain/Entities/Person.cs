namespace Domain.Entities
{
    public class Person:ICreateEntity
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public byte Experience { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Location { get; set; }
        public  required string Degree { get; set; }
        public string? Bio { get; set; }
        public string? Fax { get; set; }
        public string? Website { get; set; }
        public string? AttachmentPath { get; set; }
        public required string CareerLevel { get; set; }
        public DateTime CreatedAt { get; set; }



    }
}
