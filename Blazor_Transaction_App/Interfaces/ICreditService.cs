using Blazor_Transaction_App.Models;

namespace Blazor_Transaction_App.Interfaces
{
    public interface ICreditService
    {
        ITransactionService TransactionService { get; } 
        Task CreditAmount(TransactionModel transaction); 
    }
}
