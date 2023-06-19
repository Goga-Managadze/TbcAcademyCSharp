// See https://aka.ms/new-console-template for more information

using Partial;

BankAccount account = new BankAccount("123","Account", "USD",100);
BankAccount account1 = new BankAccount("456", "Account1", "USD", 500);

account.TransferFunds(account1, 50);
account.Deposit(50);
account.BalanceCheck();
account1.BalanceCheck();

