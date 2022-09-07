using Blazor_Transaction_App.Models;

namespace Blazor_Transaction_App.Interfaces
{
    public interface ITransactionService
    {
        Task<IEnumerable<TransactionModel>> GetAllTransactions();
        Task CreditAmount(TransactionModel transaction); 
        string SetDebitAmount(TransactionModel transaction);
    }
}
