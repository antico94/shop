namespace Shop.Models;

public class ShoppingCart
{
    public int UserId { get; set; }
    public ICollection<Product> Products { get; set; }
    public double Total { get; set; }
}