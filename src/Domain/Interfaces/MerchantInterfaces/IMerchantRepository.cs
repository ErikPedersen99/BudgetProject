using Domain.Entities;

namespace Domain.Interfaces;

public interface IMerchantRepository : IRepository<Merchant>
{
    Task<Merchant?> GetByNormalizedNameAsync(string normalizedName);
}