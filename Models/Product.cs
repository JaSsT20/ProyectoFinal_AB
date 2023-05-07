using System.ComponentModel.DataAnnotations;

public class Product
{
    [Key]
    public int ProductId { get; set; }
    public string Name { get; set; } = string.Empty;
    [Range(1, 10000, ErrorMessage = "El rango del valor es de {1} y {2}")]
    public float Price { get; set; }
    public string Brand { get; set; } = string.Empty;
    public DateTime EntryDate { get; set; } = DateTime.Today;
    public int Existence { get; set; }
}