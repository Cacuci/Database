namespace LMTDatabase.Models;

public partial class Package
{
    public Guid Id { get; set; }

    public string Type { get; set; } = null!;

    public int Capacity { get; set; }

    public bool Active { get; set; }

    public Guid ProductId { get; set; }

    public virtual ICollection<Barcode> Barcodes { get; set; } = new List<Barcode>();

    public virtual Product Product { get; set; } = null!;
}
