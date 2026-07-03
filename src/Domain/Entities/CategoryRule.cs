namespace Domain.Entities;

public class CategoryRule
{
    public Guid CategoryRuleId {get;set;}
    public Guid UserId {get;set;}
    public string MatchPattern {get;set;} = null!;
    public Guid CategoryId {get;set;}
    public DateTime CreatedAt {get;set;}

    public Category? Category {get;set;}
    public User? User {get;set;}
}