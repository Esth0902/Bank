Person p = new Person();
p.FirstName = "Esther";
p.LastName = "Stassin";
p.BirthDate = new DateTime(1992, 2, 9);


// 1. Créer une classe "Person" implémentant les propriétés publiques
// string FirstName, string LastName, DateTime BirthDate
public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    
}

    
// 2. Créer une classe "CurrentAccount" qui permet la gestion d'un compte courant implémentant
// les propriétés publiques string Number, double Balance (lecture seule), double CreditLine, Person Owner
// les méthodes publiques void Withdraw(double amount), void Deposit(double amount)

public class CurrentAccount
{
    public string Number { get; set; }
    public double Balance { get; private set; }
    public double CreditLine { get; set; }
    public Person Owner { get; }

    public void Withdraw(double amount)
    {
        
    }

    public void Deposit(double amount)
    {
        
    }
}

// 3. Créer une classe "bank" pour gérer les comptes de la banque en implémentant
// les propriétés Dictionary<string, Current> Accounts (lecture seule), string Name
// les méthodes void AddAccount(Current account), void DeleteAccount(string number)

