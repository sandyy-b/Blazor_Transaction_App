using Blazor_Transaction_App.Interfaces;
using Blazor_Transaction_App.Models;

namespace Blazor_Transaction_App.Services
{
    public class DebitService : IDebitService
    {
        private readonly ITransactionService _transactionService;

        public DebitService(ITransactionService transactionService) 
        {
            _transactionService = transactionService;
        }

        public ITransactionService TransactionService => throw new NotImplementedException();

        public string DebitAmount(TransactionModel transaction) 
        {
            return  _transactionService.SetDebitAmount(transaction);
        }
    }
}
