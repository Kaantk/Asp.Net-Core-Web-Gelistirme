namespace PartProject_2.Models
{
    public class Course
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Instructor { get; set; }

        public string? Description { get; set; }

        public string? ImageUrl { get; set; }

        public string[]? Tags { get; set; }

        public Boolean? isActive { get; set; }
    }
}
