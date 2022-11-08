namespace SomeBankingService
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new() { Balance = 1000 };

            account.CalculateInterest(new BasicAccCalculator());
            Console.WriteLine(account.Interest);

            account.CalculateInterest(new PayrollAccCalculator());
            Console.WriteLine(account.Interest);
        }
    }
}