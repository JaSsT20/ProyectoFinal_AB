using System.ComponentModel.DataAnnotations;

public class Sale
{
    [Key]
    public int SaleId { get; set; }
    public int ClientId { get; set; }
    public int Quantity { get; set; }
    public DateTime SaleDate { get; set; }
    public float Total { get; set; }
    public List<SaleDetail> SalesDetails { get; set; } = new List<SaleDetail>();

} 