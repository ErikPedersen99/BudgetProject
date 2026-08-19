namespace Domain.Entities;

public class Transaction
{
    public Guid TransactionId {get;set;}
    public Guid UserId {get;set;}
    public Guid BankAccountId {get;set;}
    public string? ExternalId {get;set;} = null!;
    public Guid? MerchantId {get;set;} 
    public decimal Amount {get;set;}
    public string Currency {get;set;} = null!;
    public DateTime Date {get;set;}
    public string Description {get;set;} =null!;
    public TransactionType Type {get;set;}
    public Guid? CategoryId {get;set;}
    public DateTime CreatedAt {get;set;}

    public BankAccount? BankAccount {get;set;}
    public Category? Category {get;set;}
    public User? User {get;set;}
    public Merchant? Merchant {get;set;}
}