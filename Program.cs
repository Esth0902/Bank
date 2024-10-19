

using System.Runtime;
using Bank;


var bank = new Bank1() {Name = "Ifosup"};
var esther = new Person() {FirstName = "Esther", LastName = "Stassin"};
var account1 = new CurrentAccount() {Number = "A1", Owner = esther };
var account2 = new CurrentAccount() {Number = "A2", Owner = esther };
var saving1 = new SavingsAccount() {Number = "S1", Owner = esther };
var test = new Person() {FirstName = "Test", LastName = "Testlastname"};
var account4 = new CurrentAccount() {Number = "A3", Owner = test };
var saving2 = new SavingsAccount() {Number = "S2", Owner = test };

bank.AddAccount(account1);
account1.Deposit(500);
account1.Withdraw(100);

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



