namespace SomeBankingService
{
    public class BasicAccCalculator : ICalculator
    {
        // Метод для расчета процентной ставки
        public void CalculateInterest(Account account)
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            account.Interest = account.Balance * 0.4;

            if (account.Balance < 1000)
                account.Interest -= account.Balance * 0.2;

            if (account.Balance < 50000)
                account.Interest -= account.Balance * 0.4;
        }
    }
}