using Blazor_Transaction_App.Models;

namespace Blazor_Transaction_App.Interfaces
{
    public interface IViewAllTransactions
    {
        Task<IEnumerable<TransactionModel>> GetAllTransactions(); 
    }
}
