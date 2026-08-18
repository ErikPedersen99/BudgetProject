namespace Domain.Entities;

public class RecurringTransaction
{
    public Guid RecurringTransactionId   {get;set;}
    public Guid UserId {get;set;}
    public Guid? CategoryId {get;set;}
    public string Name {get;set;} = null!;
    public decimal Amount {get;set;}
    public string Currency {get;set;} = null!;
    public TransactionType Type {get;set;}
    public int? DueDate {get;set;}

    public RecurringFrequency Frequency {get;set;}
    public DateTime StartDate {get;set;}
    public DateTime? EndDate {get;set;}
    public DateTime? NextExecutionDate  {get;set;}
    public DateTime CreatedAt {get;set;}
    
    public User? User {get;set;}
    public Category? Category {get;set;}
}