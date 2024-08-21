namespace ConsoleBank.Aggregate
{
    public interface ICheckingAccountAggregate
    {
        float Withdraw(float amount, string currency);
        float Deposit(float amount, string currency);
    }
}
