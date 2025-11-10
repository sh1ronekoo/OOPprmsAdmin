using System;
using System.IO;
using System.Text;
using System.Threading;

namespace admindash
{
    public static class Logger
    {
        private static readonly object _fileLock = new();
        private static readonly string _logDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "admindash", "logs");
        private static readonly string _logFile = Path.Combine(_logDir, "app.log");

        public static event Action<string>? LogAppended;

        private static void EnsureLogDirectory()
        {
            try
            {
                if (!Directory.Exists(_logDir))
                    Directory.CreateDirectory(_logDir);
            }
            catch
            {
                // swallow - best effort
            }
        }

        private static void Write(string level, string message)
        {
            var ts = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff");
            var line = $"{ts} [{level}] {message}";
            try
            {
                EnsureLogDirectory();
                lock (_fileLock)
                {
                    File.AppendAllText(_logFile, line + Environment.NewLine, Encoding.UTF8);
                }
            }
            catch
            {
                // best effort file write; don't throw from logger
            }

            try
            {
                LogAppended?.Invoke(line);
            }
            catch
            {
                // swallow UI event exceptions
            }
        }

        public static void Info(string message) => Write("INFO", message);
        public static void Warn(string message) => Write("WARN", message);
        public static void Error(string message) => Write("ERROR", message);
        public static void Debug(string message) => Write("DEBUG", message);
    }
}