using System.ComponentModel.DataAnnotations;

public class Products
{
    [Key]
    public int ProductId {get; set;}
    public string Name {get; set;} = string.Empty;

    [Range(1, 10000, ErrorMessage = "El rango del valor es de {1} y {2}")]
    public float Price {get; set;}
    public DateTime EntryDate { get; set; } = DateTime.Today;



}