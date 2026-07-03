using System.Transactions;

namespace Domain.Entities;

public class BankAccount
{
    public Guid BankAccountId {get;set;}
    public Guid UserId {get;set;}
    public string ExternalId {get;set;} = null!;
    public string Name {get;set;} = null!;
    public decimal Balance {get;set;}
    public string Currency {get;set;} = null!;
    public DateTime? LastSyncedAt {get;set;}
    public DateTime CreatedAt {get;set;}

    public User? User {get;set;}
    public ICollection<Transaction>? Transactions {get;set;}
    }