namespace Bank;

//18. Dans la classe Account : 
// au niveau de la méthode "Deposit" déclenchez une exception de type "ArgumentOutOfRangeException", si le montant n'est pas supérieur à 0
// Withdraw : idem + déclenchement exception "InsufficientBalanceException" si montant ne peut être retiré


// 12. Définir l'interface "IAccount", afin de limiter l'accès à consulter la propriété "Balance" et d'utiliser les méthodes
// Deposit et Withdraw

public class InsufficientBalanceException : Exception 
{
    public InsufficientBalanceException(string message) : base(message)
    {
        Console.WriteLine(message);
    }
}

public interface IAccount
{
    public double Balance { get; }
    public void Withdraw(double amount);
    public void Deposit(double amount);
}



// 13. Définir l'interface "IBankAccount" ayant les mêmes fonctionnalités que "IAccount". Elle lui permettra en plus d'invoquer
// la méthode du "ApplyInterest" et offrir un accès en lecture seule au "Owner" et au "Number".

public interface IBankAccount : IAccount // reprend les règles du contrat de IAccount et en ajoute
{
    public double ApplyInterest();
    public Person Owner { get; }
    public string Number { get; }
}

// Ajouter dans la classe account deux constructeurs prenant en paramètre 
// le numéro et le titulaire
// le numéro, le titulaire et le solde (pour le cas d'une base de données)

public abstract class Account : IBankAccount
{
    public override string ToString()
    {
        return $"Account ID : {Number} - Owner : {Owner} - Balance : {Balance}"; //pour la fonction display account
    }
    
    public string Number { get; private set; }
    public double Balance { get; private set; }
    public Person Owner { get; private set; }

    public Account(Person owner, string number, double balance) // créer un nouveau compte avec Owner, numéro et solde)
    {
        Owner = owner;
        Number = number;
        Balance = balance;
    }

    public Account(Person owner, string number) // créer un nouveau compte avec uniquement owner et numéro
    {
        Number = number;
        Owner = owner;
        Balance = 0;
    }

    
    public virtual void Withdraw(double amount) // Fonction retrait de base
    {
        if (amount > 0 ) // si le montant du retrait est supérieur à 0 
        {
            Balance -= amount; //retire le montant du solde du compte
        }
        else {throw new InsufficientBalanceException("This amount can't be withdrawed");}
    }
    
    public void Deposit(double amount) // fonction versement
    {
        if (amount <= 0) // Vérification si le montant est <= 0
        {
            throw new ArgumentOutOfRangeException(nameof(amount), "The deposit amount must be greater than 0."); 
        }
        else// si le montant est supérieur à 0
        {
            Balance += amount; // ajout du montant au solde du compte
        }
    }

    protected abstract double CalculInterest(); // fonction calcul intérêts spécifique à savingaccount et currentaccount

    public double ApplyInterest() // fonction pour appliquer le calcul des intérêts au solde du compte
    {
        return Balance += CalculInterest();
    }
}
