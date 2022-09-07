using Blazor_Transaction_App.Interfaces;
using Blazor_Transaction_App.Models;

namespace Blazor_Transaction_App.Services
{
    public class ViewAllTransactions : IViewAllTransactions
    {
        private readonly ITransactionService _transactionService; 
        public ViewAllTransactions(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }

        public async Task<IEnumerable<TransactionModel>> GetAllTransactions() 
        {

            return await _transactionService.GetAllTransactions();
        }
    }
}
