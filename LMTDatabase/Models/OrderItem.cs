namespace LMTDatabase.Models;

public partial class OrderItem
{
    public Guid Id { get; set; }

    public Guid DocumentId { get; set; }

    public decimal Quantity { get; set; }

    public Guid? OrderDocumentId { get; set; }

    public Guid PackageId { get; set; }

    public Guid ProductId { get; set; }

    public virtual OrderDocument? OrderDocument { get; set; }
}
