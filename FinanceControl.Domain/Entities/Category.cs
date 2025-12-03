namespace FinanceControl.Domain.Entities;

public class Category
{
    public Guid Id { get; private set; }
    public string? Name { get; private set; }
    public TransactionType TypeCategory { get; private set; }

    public Category(string name, TransactionType typeCategory)
    {
        Name = name;
        TypeCategory = typeCategory;
    }

    public Category(Guid id, Guid userId, string name, TransactionType typeCategory)
    {
        Id = id;
        Name = name;
        TypeCategory = typeCategory;
    }

    private Category() { }
}
