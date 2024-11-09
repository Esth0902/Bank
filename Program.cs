

using System.Formats.Asn1;
using System.Runtime;
using Bank;

/*void Withdrawal(IAccount account, double amount)
{
    account.Withdraw(amount);
    Console.WriteLine(account.Balance);
}
*/

var bank = new Bank1() {Name = "Ifosup"};
var esther = new Person() {FirstName = "Esther", LastName = "Stassin"};
var account1 = new CurrentAccount(esther, "A1", 100) {CreditLine = -100 };
var account2 = new CurrentAccount(esther, "A2");
var saving1 = new SavingsAccount(esther, "S1");
var test = new Person() {FirstName = "Test", LastName = "Testlastname"};
var account4 = new CurrentAccount(test, "A3") { CreditLine = -200 };
var saving2 = new SavingsAccount(test, "S2") {};

bank.AddAccount(account1);

bank.AddAccount(account2);
account2.Deposit(2000);
account2.Withdraw(200);

bank.AddAccount(saving1);
saving1.Deposit(10000);
saving1.Withdraw(2000);

bank.AddAccount(account4);
account4.Deposit(1000);

bank.AddAccount(saving2);
saving2.Deposit(1000);

bank.GetBalance(account1);
bank.GetBalance(account2);
bank.GetBalance(saving1);

bank.DisplayAccounts();

bank.Total(esther);
bank.Total(test);

account1.ApplyInterest();
bank.GetBalance(account1);

saving1.ApplyInterest();
bank.GetBalance(saving1);

//Withdrawal(account1, 500);
