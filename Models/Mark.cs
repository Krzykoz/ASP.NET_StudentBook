using Microsoft.AspNetCore.Identity;

namespace ASP.NET_Student_Book.Models;

public class Mark
{
    public int MarkId { get; set; }
    public int ReceivedMark { get; set; }
    public String? Comment { get; set; }
    public int StudentId { get; set; }
    public int GradeId { get; set; }

    public Student Student { get; set; }
    public Grade Grade { get; set; }
    
}