namespace ASP.NET_Student_Book.Models;

public class Class
{
    public int ClassId { get; set; }
    public String Name { get; set; }
    
    public ICollection<Course> Courses { get; set; }
    public ICollection<Student> Students { get; set; }
    public ICollection<Grade> Grades { get; set; }


}