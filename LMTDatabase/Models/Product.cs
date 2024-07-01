namespace LMTDatabase.Models;

public partial class Product
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool Active { get; set; }

    public virtual ICollection<Package> Packages { get; set; } = new List<Package>();
}
