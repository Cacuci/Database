namespace LMTDatabase.Models;

public partial class Warehouse
{
    public Guid Id { get; set; }

    public string Code { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime DateRegister { get; set; }

    public bool Active { get; set; }
}
