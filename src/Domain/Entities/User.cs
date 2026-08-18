using System.Transactions;

namespace Domain.Entities;

public class User
{
    public Guid UserId {get;set;}
    public string Name {get;set;} = null!;
    public string Email {get;set;} = null!;
    public string PasswordHash {get;set;} = null!;
    public string? GoCardlessUserId {get;set;}
    public DateTime CreatedAt {get;set;}
    public DateTime UpdatedAt {get;set;}

    public ICollection<BankAccount>? BankAccounts {get;set;}
    public ICollection<Budget>? Budgets {get;set;}
    public ICollection<Category>? Categories {get;set;}
    public ICollection<CategoryRule>? CategoryRules {get;set;}
    public ICollection<RecurringTransaction>? RecurringTransactions {get;set;}
    public ICollection<Transaction>? Transactions {get;set;}

}