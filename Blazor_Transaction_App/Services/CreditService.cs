using Blazor_Transaction_App.Interfaces;
using Blazor_Transaction_App.Models;

namespace Blazor_Transaction_App.Services
{
    public class CreditService : ICreditService 
    {
        private readonly ITransactionService _transactionService;

        public CreditService(ITransactionService transactionService)  
        {
            _transactionService = transactionService;    
        }

        public ITransactionService TransactionService => throw new NotImplementedException();

        public async Task CreditAmount(TransactionModel transaction)
        {
           await _transactionService.CreditAmount(transaction);
        }
    }
}
