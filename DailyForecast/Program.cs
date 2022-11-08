namespace DailyForecast
{
    public static class Constants
    {
        // Выносим повторяющийся код в константы
        public const string WelcomeString = "Welcome to the forecast page for the";
        public const string ForecastString = "The average temperature expects to be around ";
        public const string LineBreak = "\n"; // заменяем лишние вызовы Console.Writeline на символ переноса строки
    }

    class Program
    {
        static void Main(string[] args)
        {
            DailyAverage();
            WeeklyAverage();
            MonthlyAverage();
        }

        // используем форматирование для подстановки

        private static void DailyAverage()
        {
            Console.WriteLine($"{Constants.WelcomeString} day {Constants.LineBreak}{Constants.ForecastString} {new Random().Next(10, 30)} {Constants.LineBreak}");
        }

        private static void WeeklyAverage()
        {
            Console.WriteLine($"{Constants.WelcomeString} week {Constants.LineBreak}{Constants.ForecastString} {new Random().Next(10, 30)} {Constants.LineBreak}");
        }

        private static void MonthlyAverage()
        {
            Console.WriteLine($"{Constants.WelcomeString} month {Constants.LineBreak}{Constants.ForecastString} {new Random().Next(10, 30)} {Constants.LineBreak}");
        }
    }
}