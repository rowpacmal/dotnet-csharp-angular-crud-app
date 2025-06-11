namespace server.Models;

public class Book
{
    public int Id { get; set; } // Primary key
    public string Title { get; set; } = null!;
    public string Author { get; set; } = null!;
    public DateTime Publication_Date { get; set; }
}
