using Shop.Models.Enums;

namespace Shop.Models;

public class Order
{
    public int OrderId { get; set; }
    public int UserId { get; set; }
    public ICollection<Product> Products { get; set; }
    public DateOnly Date { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public string Address { get; set; }
}