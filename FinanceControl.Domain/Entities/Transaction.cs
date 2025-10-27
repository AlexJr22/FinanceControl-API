namespace FinanceControl.Domain.Entities;

public class Transaction(
    Guid id,
    Guid userId,
    Guid accountId,
    Guid categoryId,
    decimal amount,
    DateTime date,
    DateTime createdAt,
    string description,
    TransactionType typeTransaction
)
{
    public Guid Id { get; set; } = id;
    public Guid UserId { get; set; } = userId;
    public Guid AccountId { get; set; } = accountId;
    public Guid CategoryId { get; set; } = categoryId;
    public decimal Amount { get; set; } = amount;
    public TransactionType TypeTransaction { get; set; } = typeTransaction;
    public DateTime Date { get; set; } = date;
    public DateTime createdAt { get; set; } = createdAt;
    public string Description { get; set; } = description;
}
