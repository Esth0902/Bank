
namespace Bank;

// Créer une classe "savingsAccount" pour la gestion d'un carnet d'épargne implémentant :
// les propriétés publiques string Number, double Balance (lecture seule), DateTime DateLastWithdraw, Person Owner
// Les méthodes publiques : void Withdraw (double amount), void Deposit (double amount)
/*
public class SavingsAccount : Account
{
    public DateTime DateLastWithdraw { get; set; }


    protected override double CalculInterest()
    {
        var interest = Balance * 0.045;
        return interest;
    }
    
}

*/


//15. Le cas échéant, ajoutez le ou les constructeurs aux classes "current" et "Savingsaccounts"

public class SavingsAccount : Account // héritage de la classe Account
{
    public DateTime DateLastWithdraw { get; private set; } // ?? à chaque retrait, mettre à jour lastwithdraw
    public SavingsAccount(Person owner, string number, double balance) : base(owner, number, balance){}
    public SavingsAccount(Person owner, string number) : base(owner, number) {}

    
    public override void Withdraw(double amount) // Fonction retrait savingaccount
    {
    if (amount < Balance) // si le montant à retirer est plus petit que le solde
        {
            base.Withdraw(amount);//appelle la fonction withdraw de la classe Account
            DateLastWithdraw = DateTime.Now;
            Console.WriteLine($"withdrawal sucessful, new balance : {Balance}, date lastwithdrawal : {DateLastWithdraw}");
        }
    else // sinon, message info "vous n'avez pas assez d'argent pour le retrait)
        {
            Console.WriteLine($"You don't have enough money to withdraw");
        }
    }
    
    protected override double CalculInterest() //calcul des intérêts pour savingsaccounts
    {
        var interest = Balance * 0.045; // balance x 4,5 %
        return interest; // retourne le montant des intérêts à appliquer
    }
    
}