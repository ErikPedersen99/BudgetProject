namespace Domain.Entities;

public enum TransactionType
{
    Income,
    Expense
}

public enum CategoryType
{
    Income,
    Fixed,
    Variable
}

public enum RecurringFrequency
{
    Daily,
    Weekly,
    Monthly,
    Yearly
    }