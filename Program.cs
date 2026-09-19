
namespace OOPPrinciplesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar ett vanligt bankkonto.
            BankAccount account = new BankAccount("Ali", 5000);

            // Skapar ett sparkonto.
            SavingsAccount savingsAccount = new SavingsAccount("Sara", 10000);

            // Anropar metoderna från de olika kontotyperna.
            account.ShowAccountInfo();
            savingsAccount.ShowAccountInfo();
        }
    }

    // En abstrakt klass fungerar som en grund för andra kontoklasser.
    public abstract class Account
    {
        public string AccountHolder;
        public double Balance;

        // Konstruktor som används av klasser som ärver från Account.
        protected Account(string accountHolder, double balance)
        {
            AccountHolder = accountHolder;
            Balance = balance;
        }

        // Abstrakt metod som måste implementeras av underklasserna.
        public abstract void ShowAccountInfo();
    }

    // BankAccount ärver från den abstrakta klassen Account.
    public class BankAccount : Account
    {
        // Konstruktor som använder basklassens konstruktor.
        public BankAccount(string accountHolder, double balance)
            : base(accountHolder, balance)
        {
        }

        // Implementerar den abstrakta metoden från Account.
        public override void ShowAccountInfo()
        {
            Console.WriteLine($"Vanligt bankkonto: {AccountHolder}, saldo: {Balance} kr");
        }
    }

    // SavingsAccount ärver också från Account.
    public class SavingsAccount : Account
    {
        // Konstruktor som använder basklassens konstruktor.
        public SavingsAccount(string accountHolder, double balance)
            : base(accountHolder, balance)
        {
        }

        // Implementerar den abstrakta metoden från Account.
        public override void ShowAccountInfo()
        {
            Console.WriteLine($"Sparkonto: {AccountHolder}, saldo: {Balance} kr");
        }
    }
}
