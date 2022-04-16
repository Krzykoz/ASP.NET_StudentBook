using Microsoft.AspNetCore.Identity;

namespace ASP.NET_Student_Book.Models;

public class Teacher
{
    public int TeacherId { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public String IdentityUserId { get; set; }
    
    public IdentityUser IdentityUser { get; set; }
    
    public ICollection<Course> Courses { get; set; }
    public ICollection<Grade> Grades { get; set; }

}