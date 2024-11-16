

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
var esther = new Person("Esther", "Stassin");
var account1 = new CurrentAccount(esther, "A1", 100) {CreditLine = -300 };
var saving1 = new SavingsAccount(esther, "S1");
var test = new Person("Test", "Testlastname");
var account2 = new CurrentAccount(test, "A2") { CreditLine = -200 };
var saving2 = new SavingsAccount(test, "S2") {};

bank.AddAccount(account1);
bank.AddAccount(account2);
account2.Deposit(2000);

try
{account2.Deposit(2000);}
catch (ArgumentOutOfRangeException ex)
{Console.WriteLine(ex.Message);}

account2.Withdraw(200);

account1.Withdraw(200);

bank.AddAccount(saving1);
saving1.Deposit(10000);
saving1.Withdraw(2000);
try {saving1.Withdraw(-100);}
catch (InsufficientBalanceException ex)
    {Console.WriteLine(ex.Message);}

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
