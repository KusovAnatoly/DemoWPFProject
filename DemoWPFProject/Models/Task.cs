namespace DemoWPFProject.Models;

public class Task
{
    public string Title { get; set; } = null!;
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }
}
