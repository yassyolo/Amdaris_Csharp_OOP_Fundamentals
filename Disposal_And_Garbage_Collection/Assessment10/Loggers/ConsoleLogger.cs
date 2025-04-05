namespace Assessment10.Loggers
{
    internal class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[INFO] - {DateTime.Now:yyyy-MM-dd HH:mm:ss} {message}");
        }
    }
}
