namespace Homework_13_1;

class Program
{
    static void Main(string[] args)
    {
        var pluginManager = new PluginManager();
        pluginManager.LoadPlugin(new CalculatorPlugin());
        pluginManager.LoadPlugin(new GreetingsPlugin());

        pluginManager.ExecutePlugins();
    }
}