namespace Bank;

public abstract class Account
{
    public override string ToString()
    {
        return $"Account ID : {Number} - Owner : {Owner} - Balance : {Balance}";
    }

    public string Number { get; set; }
    public double Balance { get; private set; }
    public Person Owner { get; set; }
    
    public virtual void Withdraw(double amount)
    {
        if (amount > 0 && Balance > amount)
        {
            Balance -= amount;
        }
    }
    
    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
        }
    }

    protected abstract double CalculInterest();

    public double ApplyInterest()
    {
        return Balance += CalculInterest();
    }
}
