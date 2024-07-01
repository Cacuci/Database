namespace LMTDatabase.Models;

public partial class Barcode
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public bool Active { get; set; }

    public Guid PackageId { get; set; }

    public virtual Package Package { get; set; } = null!;
}
