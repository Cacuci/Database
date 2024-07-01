namespace LMTDatabase.Models;

public partial class OrderDocument
{
    public Guid Id { get; set; }

    public Guid OrderId { get; set; }

    public string Number { get; set; } = null!;

    public virtual Order Order { get; set; } = null!;

    public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
