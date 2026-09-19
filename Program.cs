
namespace OOPPrinciplesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Skapar ett vanligt bankkonto.
            BankAccount account = new BankAccount("Ali", 5000);
            account.ShowBalance();

            Console.WriteLine();

            // Skapar ett sparkonto som ärver från BankAccount.
            SavingsAccount savingsAccount = new SavingsAccount("Sara", 10000);
            savingsAccount.ShowBalance();
        }
    }

    // Basklass som representerar ett vanligt bankkonto.
    public class BankAccount
    {
        public string AccountHolder;
        public double Balance;

        // Konstruktor som används för att skapa ett bankkonto.
        public BankAccount(string accountHolder, double balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        // Metod som visar kontoinnehavare och aktuellt saldo.
        public void ShowBalance()
        {
            Console.WriteLine($"Account holder: {AccountHolder}");
            Console.WriteLine($"Balance: {Balance} kr");
        }
    }

    // SavingsAccount ärver egenskaper och metoder från BankAccount.
    public class SavingsAccount : BankAccount
    {
        // Konstruktor som använder konstruktorn från basklassen.
        public SavingsAccount(string accountHolder, double balance)
            : base(accountHolder, balance)
        {
        }
    }
}
