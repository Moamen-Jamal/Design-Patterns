namespace Singleton.Start.Start
{
    public sealed class MemoryLogger
    {
        private static Lazy<MemoryLogger> Instance 
            = new Lazy<MemoryLogger>(() => new MemoryLogger());
        
        private int _InfoCount;
        private int _WarningCount;
        private int _ErrorCount;

        private List<LogMessage> _logs = new List<LogMessage>();

        public IReadOnlyCollection<LogMessage> Logs => _logs;

        public static MemoryLogger getLoger
        {
            get
            {
                return Instance.Value;
            }
        }
        
        private MemoryLogger(){}
        private void Log(string message, LogType logType)
        {
            _logs.Add(new LogMessage()
            {
                Message = message,
                LogType = logType,
                CreatedAt = DateTime.Now
            });
        }

        public void LogInfo(string message)
        {
            ++_InfoCount;
            Log(message, LogType.INFO);
        }
        public void LogWarning(string message)
        {
            ++_WarningCount;
            Log(message, LogType.WARNING);
        }
        public void LogError(string message)
        {
            ++_ErrorCount;
            Log(message, LogType.ERROR);
        }

        public void ShowLog()
        {
            _logs.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("---------------------------");
            Console.WriteLine($"InfoCount  ({_InfoCount}),  WarningCount ({_WarningCount}), ErrorCount ({_ErrorCount})");
        }
    }
}
