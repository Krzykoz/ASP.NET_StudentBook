using Microsoft.AspNetCore.Identity;

namespace ASP.NET_Student_Book.Models;

public class Student
{
    public int StudentId { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public int ClassId { get; set; }
    public String IdentityUserId { get; set; }

    public Class Class { get; set; }
    public IdentityUser IdentityUser { get; set; }
    
    public ICollection<Mark> Marks { get; set; }

}