namespace Assessment10.Loggers
{
    internal class FileLogger : ILogger, IDisposable
    {
        private static readonly string _filePath;
        private static readonly StreamWriter _streamWriter;

        static FileLogger()
        {
            var _filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt");

            if(!File.Exists(_filePath))
            {
                File.Create(_filePath).Dispose();
            }

            _streamWriter = new StreamWriter(_filePath, true)
            {
                AutoFlush = true
            };
        }

        public void Dispose()
        {
            _streamWriter?.Dispose();
        }

        public void Log(string message)
        {
            string logEntry = $"[INFO] - {DateTime.Now:yyyy-MM-dd HH:mm:ss} {message}";
            _streamWriter.WriteLine(logEntry);
        }
    }
}
