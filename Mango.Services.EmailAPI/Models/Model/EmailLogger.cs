namespace Mango.Services.EmailAPI.Models.Model;

public class EmailLogger
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Message { get; set; }
    public DateTime? EmailSent { get; set; }
}
