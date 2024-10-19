namespace Bank;

// Créer une classe "savingsAccount" pour la gestion d'un carnet d'épargne implémentant :
// les propriétés publiques string Number, double Balance (lecture seule), DateTime DateLastWithdraw, Person Owner
// Les méthodes publiques : void Withdraw (double amount), void Deposit (double amount)

public class SavingsAccount : Account
{
    public DateTime DateLastWithdraw { get; set; }


    protected override double CalculInterest()
    {
        var interest = Balance * 0.045;
        return interest;
    }
    
}


