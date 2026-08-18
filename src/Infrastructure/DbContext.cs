using MySql.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure;

public class AppDbContext : DbContext
{
    public BudgetDbContext(DbContextOptions<AppDbContext> options): base(options) { }

    public DbSet<User> Users  {get;set;}
    public DbSet<BankAccount> BankAccounts {get;set;}
    public DbSet<Budget> Budgets {get;set;}
    public DbSet<Category> Categories {get;set;}
    public DbSet<CategoryRule> CategoryRules {get;set;}
    public DbSet<Merchant> Merchants {get;set;}
    public DbSet<RecurringTransaction> RecurringTransactions {get;set;}
    public DbSet<Transaction> Transactions {get;set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //Enums

        modelBuilder.Entity<Transaction>()
        .Property(t => t.Type)
        .HasConversion<string>();

        modelBuilder.Entity<RecurringTransaction>()
        .Property(r => r.Type)
        .HasConversion<string>();
        
        modelBuilder.Entity<Category>()
        .Property(c => c.Type)
        .HasConversion<string>();

        modelBuilder.Entity<RecurringTransaction>()
        .Property(r => r.Frequency)
        .HasConversion<string>();        
    }
}