
namespace OOPPrinciplesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Skapar ett nytt bankkonto för Ali med ett saldo på 5000 kr.
            BankAccount account = new BankAccount("Ali", 5000);

            // Ändrar saldot genom publika metoder.
            account.Deposit(1000);
            account.Withdraw(500);

            // Visar kontoinnehavare och aktuellt saldo.
            account.ShowBalance();
        }
    }

    // Klassen BankAccount representerar ett enkelt bankkonto.
        public class BankAccount
        {
        // Privata fält skyddar informationen från att ändras direkt utifrån klassen.
        private string accountHolder;
        private double balance;
        // Konstruktor som används för att skapa ett nytt bankkonto.
        public BankAccount(string accountHolder, double balance)
        {
            this.accountHolder = accountHolder;
            this.balance = balance;
        }

        // Metod som används för att sätta in pengar på kontot.
        public void Deposit(double amount)
        {
            balance += amount;
        }

        // Metod som används för att ta ut pengar från kontot.
        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
            }
        }

        // Metod som visar kontoinnehavare och aktuellt saldo.
        public void ShowBalance()
        {
            Console.WriteLine($"Account holder: {accountHolder}");
            Console.WriteLine($"Balance: {balance} kr");
        }
    }
}
