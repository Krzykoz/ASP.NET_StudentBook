using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ASP.NET_Student_Book.Models;

public class Grade
{
    public int GradeId { get; set; }
    public String Name { get; set; }
    public int Weight { get; set; }
    public DateOnly Date { get; set; }
    public int?  GradeTypeId { get; set; }
    public Guid TeacherId { get; set; }
    public int ClassId { get; set; }
    public int CourseId { get; set; }

    public GradeType GradeType { get; set; }
    public Teacher Teacher { get; set; }
    public Class Class { get; set; }
    public Course Course { get; set; }
}