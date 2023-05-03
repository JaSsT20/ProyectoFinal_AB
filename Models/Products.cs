using System.ComponentModel.DataAnnotations;

public class Products
{
    [Key]
    public int ProductId {get; set;}
    public string Name {get; set;} = string.Empty;
}