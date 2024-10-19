namespace Bank;

// 1. Créer une classe "Person" implémentant les propriétés publiques
// string FirstName, string LastName, DateTime BirthDate
public class Person
{
    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }

    public int ID { get; init; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public DateTime BirthDate { get; set; }
}