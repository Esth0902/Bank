namespace Bank;

// 1. Créer une classe "Person" implémentant les propriétés publiques
// string FirstName, string LastName, DateTime BirthDate
public class Person
{
    public int ID { get; init; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
}