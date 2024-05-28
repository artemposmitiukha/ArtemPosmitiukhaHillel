
using System.Runtime.InteropServices.JavaScript;

namespace Homework_13_2;

public static class Logger
{
    private static Dictionary<DateTime, string> logs = new Dictionary<DateTime, string>();
    public static void AddLog(string message)
    {
        LogEntry log = new LogEntry();
        log.Timestamp = DateTime.Now;
        log.Message = message;
        logs.Add(log.Timestamp, log.Message);
    }

    public static Dictionary<DateTime, string> GetLogs()
    {
        return logs;
    }
}