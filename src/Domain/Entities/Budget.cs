namespace Domain.Entities;

public class Budget
{
    public Guid BudgetId {get;set;}
    public Guid UserId {get;set;}
    public Guid CategoryId {get;set;}
    public int Month {get;set;}
    public int Year {get;set;}
    public decimal Limit {get;set;}
    public string Currency {get;set;} = null!;
    public DateTime CreatedAt {get;set;}

    public Category? Category {get;set;}
    public User? User {get;set;}
}