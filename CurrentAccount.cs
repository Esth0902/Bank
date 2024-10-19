namespace Bank;

// 2. Créer une classe "CurrentAccount" qui permet la gestion d'un compte courant implémentant
// les propriétés publiques string Number, double Balance (lecture seule), double CreditLine, Person Owner
// les méthodes publiques void Withdraw(double amount), void Deposit(double amount)

public class CurrentAccount : Account
{
    public double CreditLine { get; set; }

    public override void Withdraw(double amount)
    {
        if (amount > 0 && Balance > amount && (Balance - amount) > CreditLine)
        {
            Balance -= amount;
        }
    }
    
}

