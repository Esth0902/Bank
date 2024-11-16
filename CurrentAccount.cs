namespace Bank;

// 2. Créer une classe "CurrentAccount" qui permet la gestion d'un compte courant implémentant
// les propriétés publiques string Number, double Balance (lecture seule), double CreditLine, Person Owner
// les méthodes publiques void Withdraw(double amount), void Deposit(double amount)

public class CurrentAccount : Account, IBankAccount // héritage de Account et reprend les règles du contrat de IBankAccount
{
    public CurrentAccount(Person owner, string number, double balance) : base(owner, number, balance){}
    public CurrentAccount(Person owner, string number) : base(owner, number) {}
    public double CreditLine { get; set; } // ligne de crédit (solde négatif)

    public override void Withdraw(double amount) // Fonction retrait
    {
        if ((Balance - amount) > CreditLine) //si le solde - le montant du retrait est supérieur à la ligne de crédit
        {
            base.Withdraw(amount);//appelle la fonction withdraw de la classe Account
            Console.WriteLine($"Withdrawal successful, new balance : {Balance}");
        }
        else // sinon, message info "vous n'avez pas assez d'argent pour le retrait, ligne de crédit = xx
        {
            Console.WriteLine($"You don't have enough money to withdraw, credit line = {CreditLine}");
        }
    }

    protected override double CalculInterest() // calcul des intérêts pour CurrentAccount
    {
        var interest = 0.00;
        if (Balance > 0) // si le solde est positif
        {
            interest = Balance * 0.03; // intérêts = solde x 3%
        }
        else // sinon
        {
            interest = Balance * 0.0975; // intérêts = solde x 9,75 %
        }
        return interest; // retourne les intérêts à appliquer
    }

}

