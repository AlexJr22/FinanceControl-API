using FinanceControl.Domain;

namespace FinanceControl.Application.DTOs.Category;

public record class BaseCategoryDTO(Guid UserId, string Name, TransactionType TypeCategory);
