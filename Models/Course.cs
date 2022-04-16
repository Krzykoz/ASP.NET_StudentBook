using Microsoft.AspNetCore.Identity;

namespace ASP.NET_Student_Book.Models;

public class Course
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public int TeacherId { get; set; }
    public int ClassId { get; set; }

    public Teacher Teacher { get; set; }
    public Class Class { get; set; }
    
    public ICollection<Grade> Grades { get; set; }

}