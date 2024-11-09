namespace Bank;

// 12. Définir l'interface "IAccount", afin de limiter l'accès à consulter la propriété "Balance" et d'utiliser les méthodes
// Deposit et Withdraw
public interface IAccount
{
    public double Balance { get; }
    public void Withdraw(double amount);
    public void Deposit(double amount);
}



// 13. Définir l'interface "IBankAccount" ayant les mêmes fonctionnalités que "IAccount". Elle lui permettra en plus d'invoquer
// la méthode du "ApplyInterest" et offrir un accès en lecture seule au "Owner" et au "Number".

public interface IBankAccount : IAccount
{
    public double ApplyInterest();
    public Person Owner { get; }
    public string Number { get; }
}

//


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
