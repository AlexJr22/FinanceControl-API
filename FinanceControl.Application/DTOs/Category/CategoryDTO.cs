using FinanceControl.Domain;

namespace FinanceControl.Application.DTOs.Category;

public record class CategoryDTO(Guid Id, Guid UserId, string Name, TransactionType TypeCategory);
