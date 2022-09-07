using Blazor_Transaction_App.Interfaces;
using Blazor_Transaction_App.Models;
using Microsoft.EntityFrameworkCore;

namespace Blazor_Transaction_App.Services
{
    public class TransactionService : ITransactionService
    {
        private TransactionContext _dbContext;

        public TransactionService(TransactionContext dbContext)
        {
            _dbContext = dbContext;
        }       
        public async Task CreditAmount(TransactionModel transaction) 
        {
            var balance = _dbContext.Transactions.OrderByDescending(x => x.Id).Take(1).Select(x => x.Balance).ToList().FirstOrDefault();
            transaction.Balance = balance + transaction.Credit;
            transaction.Date = DateTime.Now;
            _dbContext.Transactions.Add(transaction);
            _dbContext.SaveChanges();
        }

        public string SetDebitAmount(TransactionModel transaction)
        {
            var balance = _dbContext.Transactions.OrderByDescending(x => x.Id).Take(1).Select(x => x.Balance).ToList().FirstOrDefault();
            if(balance > 0 && transaction.Debit <= balance)
            {
                transaction.Balance = balance - transaction.Debit;
                transaction.Date = DateTime.Now;
                _dbContext.Transactions.Add(transaction);
                _dbContext.SaveChanges();
                return "Withdrawl Successfull!!";
            }
            else
            {
                return "There is not sifficient Balance to Withdraw";
            }
        }

        public async Task<IEnumerable<TransactionModel>> GetAllTransactions()
        {
            return await _dbContext.Transactions.ToListAsync();
        }
    }
}
