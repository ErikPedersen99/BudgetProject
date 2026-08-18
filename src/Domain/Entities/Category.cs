using System.Transactions;

namespace Domain.Entities;

public class Category
{
    public Guid CategoryId {get; set;}
    public Guid UserId {get;set;}
    public string Name {get;set;} = null!;
    public CategoryType Type {get;set;}
    public bool IsDefault {get;set;}
    public DateTime CreatedAt {get;set;}

    public ICollection<Budget>? Budgets {get;set;}
    public User? User {get;set;}
    public ICollection<CategoryRule>? Rules {get;set;}
    public ICollection<RecurringTransaction>? RecurringTransactions {get;set;}
    public ICollection<Transaction>? Transactions {get;set;}
}