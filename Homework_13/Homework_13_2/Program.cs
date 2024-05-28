namespace Homework_13_2;

class Program
{
    static void Main(string[] args)
    {
        Logger.AddLog("Test log number 1");
        Logger.AddLog("Test log number 2");

        var logs = Logger.GetLogs();
        foreach (var log in logs)
        {
            Console.WriteLine($"Time: {log.Key} ; Log: {log.Value}");
        }
    }
}