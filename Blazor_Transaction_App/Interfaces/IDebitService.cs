using Blazor_Transaction_App.Models;

namespace Blazor_Transaction_App.Interfaces
{
    public interface IDebitService
    {
        ITransactionService TransactionService { get; } 
        string DebitAmount(TransactionModel transaction);
    }
}
