namespace Domain.Interfaces;

public interface IUnitOfWork : IDisposable
{
    IUserRepository Users {get;}
    IBankAccountRepository BankAccounts {get;}
    ITransactionRepository Transactions {get;}
    ICategoryRepository Categories {get;}
    ICategoryRuleRepository CategoryRules {get;}
    IBudgetRepository Budgets {get;}
    IRecurringTransactionRepository RecurringTransactions {get;}
    IMerchantRepository Merchants {get;}
    Task<int> SaveChangesAsync();
}