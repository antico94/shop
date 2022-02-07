using System.ComponentModel.DataAnnotations.Schema;
using Shop.Models.Enums;

namespace Shop.Models;

public class Product
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string ProductDescription { get; set; }
    public Category ProductCategory { get; set; }
    public Manufacturer ProductManufacturer { get; set; }
    public int Amount { get; set; }
}