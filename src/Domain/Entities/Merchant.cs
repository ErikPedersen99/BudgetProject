using System.Transactions;

namespace Domain.Entities;

public class Merchant
{
    public Guid MerchantId {get;set;}
    public string Name {get;set;} = null!;
    public string? NormalizedName {get;set;}
    public DateTime CreatedAt {get;set;}

    public ICollection<Transaction>? Transactions {get;set;}
}