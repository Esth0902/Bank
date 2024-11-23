namespace Bank;

// 3. Créer une classe "bank" pour gérer les comptes de la banque en implémentant
// les propriétés Dictionary<string, Current> Accounts (lecture seule), string Name
// les méthodes void AddAccount(Current account), void DeleteAccount(string number)

public class Bank1
{
    public string Name {get; set; }
    public Dictionary<string, Account> Accounts { get; } = []; // initialisation du dictionnaire Account

    
    public void AddAccount(Account account)  // Fonction AddAccount
    {
        if (!Accounts.ContainsKey(account.Number)) // si le dictionnaire accounts ne contient pas déjà le nouveau compte
        {
            Accounts.Add(account.Number, account);  //ajoute le nouveau compte
            Console.WriteLine($"Account {account.Number} has been added"); //message info
        }
        else // sinon message info ce compte existe déjà
        {
            Console.WriteLine($"Account {account.Number} already exists");
        }
    }

    public void DeleteAccount(IBankAccount account) //fonction pour supprimer un compte
    {
        if (Accounts.ContainsKey(account.Number)) // si le dictionnaire contient bien le compte à supprimer :
        {
            Accounts.Remove(account.Number); // supprimer le compte
            Console.WriteLine($"Account {account.Number} has been deleted"); // message d'info compte supprimé
        }
        else // sinon - message info ce compte n'existe pas
        {
            Console.WriteLine($"Account {account.Number} does not exist");
        }
    }

    public void DisplayAccounts() // fonction pour afficher les infos des comptes existants 
    {
        Console.WriteLine($"bank : {Name}");
        foreach (var account in Accounts) // pour chaque compte dans le dictionnaire Accounts : 
        {
            Console.WriteLine(account.Value); // affiche les infos
        }
    }
    
    public void GetBalance(Account account) // fonction pour afficher le solde du compte
    {
        Console.WriteLine(account.Balance);
    }

    public void TotalBalance(Person person) // fonction pour afficher le solde de tous les comptes d'une même personne
    {
        Console.WriteLine(Accounts.Values
            .Where(a => a.Owner == person) //=> fonction anonyme paramètre d'entrée = chaque valeur de la collection
            .Sum(account => account.Balance));
    }

    public void Total(Person person) // version longue du TotalBalance
    {
        var total = 0.0;
        foreach (var account in Accounts) // pour chaque compte dans le dictionnaire
        {
            if (account.Value.Owner == person) // si l'Owner de l'acompte est = à la personne entrée en paramètre
            {total += account.Value.Balance;} //fait la somme du solde de tous les comptes
        }
        Console.WriteLine($"Montant total du compte de {person} = {total}");
    }
    
    public void NegativeBalanceAction(Account account)
    {
        Console.WriteLine($"Le numéro de compte {account.Number} vient de passer en négatif.");
    }
    
}

    