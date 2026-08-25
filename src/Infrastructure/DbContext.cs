using MySql.EntityFrameworkCore.Extensions;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }

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

        //Relationships
        modelBuilder.Entity<BankAccount>()
        .HasOne(b => b.User)
        .WithMany(u => u.BankAccounts)
        .HasForeignKey(b => b.UserId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Transaction>()
        .HasOne(t => t.User)
        .WithMany(u => u.Transactions)
        .HasForeignKey(t => t.UserId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Transaction>()
        .HasOne(t => t.BankAccount)
        .WithMany(b => b.Transactions)
        .HasForeignKey(t => t.BankAccountId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Transaction>()
        .HasOne(t => t.Category)
        .WithMany(c => c.Transactions)
        .HasForeignKey(t => t.CategoryId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Transaction>()
        .HasOne(t => t.Merchant)
        .WithMany(m => m.Transactions)
        .HasForeignKey(t => t.MerchantId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Category>()
        .HasOne(c => c.User)
        .WithMany(u => u.Categories)
        .HasForeignKey(c => c.UserId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CategoryRule>()
        .HasOne(cr => cr.User)
        .WithMany(u => u.CategoryRules)
        .HasForeignKey(cr => cr.UserId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<CategoryRule>()
        .HasOne(cr => cr.Category)
        .WithMany(c => c.Rules)
        .HasForeignKey(cr => cr.CategoryId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Budget>()
        .HasOne(b => b.User)
        .WithMany(u => u.Budgets)
        .HasForeignKey(b => b.UserId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<Budget>()
        .HasOne(b => b.Category)
        .WithMany(c => c.Budgets)
        .HasForeignKey(b => b.CategoryId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<RecurringTransaction>()
        .HasOne(r => r.User)
        .WithMany(u => u.RecurringTransactions)
        .HasForeignKey(r => r.UserId)
        .OnDelete(DeleteBehavior.NoAction);

        modelBuilder.Entity<RecurringTransaction>()
        .HasOne(r => r.Category)
        .WithMany(c => c.RecurringTransactions)
        .HasForeignKey(r => r.CategoryId)
        .OnDelete(DeleteBehavior.NoAction);
    }
}