namespace RoundTheCode.Models;

public class Note
{
    public string Message { get; set; }
    public DateTimeOffset Created { get; set; }

    public Note(string message)
    {
        Message = message;
        Created = DateTimeOffset.Now;
    }
}

