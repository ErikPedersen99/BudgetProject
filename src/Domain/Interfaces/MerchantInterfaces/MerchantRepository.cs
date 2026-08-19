using Domain.Entities;

namespace Domain.Interfaces;

public interface MerchantRepository : IRepository<Merchant>
{
    Task<Merchant?> GetByNormalizedNameAsync(string normalizedName);
}