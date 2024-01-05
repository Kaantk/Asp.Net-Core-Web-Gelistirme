namespace PartProject_2.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new List<Course>();

        static Repository()
        {
            _courses = new List<Course> {
                new Course() {
                    Id = 1,
                    Name = "Js Kursu",
                    Instructor = "Sadık Turan",
                    Description = "Dünyanın en iyisi",
                    ImageUrl = "1.jpg",
                    Tags = new string[] { "Web Geliştirme", "Asp.Net"},
                    isActive = true,
                },
                new Course()
                {
                    Id = 2,
                    Name = "React Kursu",
                    Instructor = "Can Boz",
                    Description = "Dünyanın en iyisi",
                    ImageUrl = "2.jpg",
                    isActive = false,
                },
                new Course()
                {

                    Id = 3,
                    Name = "C# Kursu",
                    Instructor = "Gencay Yıldız",
                    Description = "Dünyanın en iyisi",
                    ImageUrl = "3.jpg",
                    isActive = true,
                }
            };
        }

        public static List<Course> Courses { get { return _courses; } }

        public static Course? GetById (int Id)
        {
            return _courses.FirstOrDefault(x => x.Id == Id);
        }

    }
}
