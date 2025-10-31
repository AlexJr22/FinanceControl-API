using FinanceControl.Application.Services.Servives.Interfaces.Transaction;

namespace FinanceControl.Application.Services.Servives.Interfaces;

public interface ITransactionService<T> : IService<T> where T : class
{
}
