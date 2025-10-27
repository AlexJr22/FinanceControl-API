namespace FinanceControl.Domain.Interfaces;

public interface IUniteOfWork
{
    ICategoryRepository CategoryRepository { get; }
    ITransactionRepository TransactionRepository { get; }
    IUserRepository UserRepository { get; }

    Task CommitAsync();
    Task DisposeAsync();
}
