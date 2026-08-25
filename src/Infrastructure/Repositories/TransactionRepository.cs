using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repositories;

public class TransactionRepository : Repository<Transaction>, ITransactionRepository
{
    public TransactionRepository(AppDbContext context) : base(context) {}

    public async Task<IEnumerable<Transaction>> GetByUserIdAsync(Guid userId) =>
    await _dbSet.Where(t => t.UserId == userId).ToListAsync();

    public async Task<IEnumerable<Transaction>> GetByDateRangeAsync(Guid userId, DateTime start, DateTime end) =>
    await _dbSet.Where(t => t.UserId == userId && t.Date >= start && t.Date <= end)
    .ToListAsync();

    public async Task<IEnumerable<Transaction>> GetByCategoryIdAsync(Guid categoryId) =>
    await _dbSet.Where(t => t.CategoryId == categoryId).ToListAsync();

    public async Task<IEnumerable<Transaction>> GetUncategorizedAsync(Guid userId) =>
    await _dbSet.Where(t => t.UserId == userId && t.CategoryId == null).ToListAsync();
}