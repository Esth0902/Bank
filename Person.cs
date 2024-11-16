namespace Bank;

// 1. Créer une classe "Person" implémentant les propriétés publiques
// string FirstName, string LastName, DateTime BirthDate
public class Person
{
    public int ID { get; init; } // Immuable après l'initialisation
    public string FirstName { get; private set; } // Setter privé
    public string LastName { get; private set; } // Setter privé
    public DateTime BirthDate { get; set; } // Modifiable si nécessaire

    // Constructeur principal
    public Person(string firstName, string lastName, DateTime birthDate)
    {
        FirstName = firstName;
        LastName = lastName;
        BirthDate = birthDate;
    }

    // Constructeur alternatif
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Redéfinition de ToString
    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
}