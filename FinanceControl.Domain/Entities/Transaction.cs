namespace FinanceControl.Domain.Entities;

public class Transaction
{
    public Guid TransactionId { get; private set; }
    public decimal Amount { get; private set; }
    public TransactionType TypeTransaction { get; private set; }
    public DateTime Date { get; private set; }
    public DateTime CreatedAt { get; private set; }
    public string? Description { get; private set; }

    public Guid CategoryId { get; private set; }
    public Category? Category { get; set; }

    public Guid UserId { get; private set; }
    public User? User { get; set; }

    public Transaction(
        Guid transactionId,
        decimal amount,
        DateTime date,
        DateTime createdAt,
        string description,
        TransactionType typeTransaction
    )
    {
        TransactionId = transactionId;
        Amount = amount;
        TypeTransaction = typeTransaction;
        Date = date;
        CreatedAt = createdAt;
        Description = description;
    }

    public Transaction(
        decimal amount,
        DateTime date,
        DateTime createdAt,
        string description,
        TransactionType typeTransaction
    )
    {
        Amount = amount;
        TypeTransaction = typeTransaction;
        Date = date;
        CreatedAt = createdAt;
        Description = description;
    }

    private Transaction() { }
}
