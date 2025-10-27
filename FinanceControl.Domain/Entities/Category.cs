namespace FinanceControl.Domain.Entities;

public class Category(Guid id, Guid userId, string name, TransactionType typeCategory)
{
    public Guid Id { get; set; } = id;
    public Guid UserId { get; set; } = userId;
    public string Name { get; set; } = name;
    public TransactionType TypeCategory { get; set; } = typeCategory;
}
