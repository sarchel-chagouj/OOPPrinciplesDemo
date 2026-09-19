namespace OOPPrinciplesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Här ska vi skapa ett objekt av typ of bankAccout.
            BankAccount account = new BankAccount("Ali", 5000);
            account.ShowBalance();
        }
    }
    //Här vill jag skapa en klass.

    public class BankAccount
    //Namnt på personen som äger kontot.
    {
        public string AccountHolder;
        public double Balance;
        //konstruktor som används för att skapa ett nytt bankkonto.
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
}  