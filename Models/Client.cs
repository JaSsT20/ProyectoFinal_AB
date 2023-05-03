using System.ComponentModel.DataAnnotations;
public class Client
{
    [Key]
    public int ClientId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Telephone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public DateTime EntryDate { get; set; } = DateTime.Today;
}