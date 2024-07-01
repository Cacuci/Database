namespace LMTDatabase.Models;

public partial class Order
{
    public Guid Id { get; set; }

    public string Number { get; set; } = null!;

    public string WarehouseCode { get; set; } = null!;

    public DateTime DateCreated { get; set; }

    public DateTime DateRegister { get; set; }

    public virtual ICollection<OrderDocument> OrderDocuments { get; set; } = new List<OrderDocument>();
}
