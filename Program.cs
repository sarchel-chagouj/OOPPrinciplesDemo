
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

            // Anropar samma metod på olika objekt.
            account.ShowAccountType();
            savingsAccount.ShowAccountType();
        }
    }

    // Basklass som representerar ett bankkonto.
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

        // Virtual gör det möjligt för en subklass att ändra beteendet.
        public virtual void ShowAccountType()
        {
            Console.WriteLine($"{AccountHolder} har ett vanligt bankkonto.");
        }
    }

    // SavingsAccount ärver från BankAccount.
    public class SavingsAccount : BankAccount
    {
        // Konstruktor som använder basklassens konstruktor.
        public SavingsAccount(string accountHolder, double balance)
            : base(accountHolder, balance)
        {
        }

        // Override ändrar beteendet från basklassen.
        public override void ShowAccountType()
        {
            Console.WriteLine($"{AccountHolder} har ett sparkonto.");
        }
    }
}
