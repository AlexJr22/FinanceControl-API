using FinanceControl.Domain;

namespace FinanceControl.Application.DTOs.Transaction;

public record class TransactionDTO(
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
{ }
