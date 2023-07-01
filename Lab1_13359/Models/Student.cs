using Microsoft.AspNetCore.Identity;

namespace Lab1_13359.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    public class UserRole : IdentityRole<int> { }
    public class UserEntity : IdentityUser<int> { }
}
