namespace Bank;

// 3. Créer une classe "bank" pour gérer les comptes de la banque en implémentant
// les propriétés Dictionary<string, Current> Accounts (lecture seule), string Name
// les méthodes void AddAccount(Current account), void DeleteAccount(string number)

public class Bank1
{
    public string Name {get; set; }
    public Dictionary<string, Account> Accounts { get; } = [];

    
    public void AddAccount(Account account)
    {
        if (!Accounts.ContainsKey(account.Number))
        {
            Accounts.Add(account.Number, account);
            Console.WriteLine($"Account {account.Number} has been added");
        }
        else
        {
            Console.WriteLine($"Account {account.Number} already exists");
        }
    }

    public void DeleteAccount(Account account)
    {
        if (Accounts.ContainsKey(account.Number))
        {
            Accounts.Remove(account.Number);
            Console.WriteLine($"Account {account.Number} has been deleted");
        }
        else
        {
            Console.WriteLine($"Account {account.Number} does not exist");
        }
    }

    public void DisplayAccounts()
    {
        Console.WriteLine($"bank : {Name}");
        foreach (var account in Accounts)
        {
            Console.WriteLine(account.Value);
        }
    }
    
    public void GetBalance(Account account)
    {
        Console.WriteLine(account.Balance);
    }

    public void TotalBalance(Person person)
    {
        Console.WriteLine(Accounts.Values
            .Where(a => a.Owner == person) //=> fonction anonyme paramètre d'entrée = chaque valeur de la collection
            .Sum(account => account.Balance)); 
    }

    public void Total(Person person) // version longue du TotalBalance
    {
        var total = 0.0;
        foreach (var account in Accounts)
        {
            if (account.Value.Owner == person)
            {total += account.Value.Balance;}
        }
        Console.WriteLine($"Montant total du compte de {person} = {total}");
    }
    
}

    