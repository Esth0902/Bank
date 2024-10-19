namespace Bank;

// 2. Créer une classe "CurrentAccount" qui permet la gestion d'un compte courant implémentant
// les propriétés publiques string Number, double Balance (lecture seule), double CreditLine, Person Owner
// les méthodes publiques void Withdraw(double amount), void Deposit(double amount)

public class CurrentAccount : Account
{
    public double CreditLine { get; set; }

    public override void Withdraw(double amount)
    {
        if ((Balance - amount) > CreditLine)
        {
            base.Withdraw(amount);
        }
        else
        {
            Console.WriteLine($"You don't have enough money to withdraw, credit line = {CreditLine}");
        }
    }

    protected override double CalculInterest()
    {
        var interest = 0.00;
        if (Balance > 0)
        {
            interest = Balance * 0.03;
        }
        else
        {
            interest = Balance * 0.0975;
        }
        return interest;
    }

}

