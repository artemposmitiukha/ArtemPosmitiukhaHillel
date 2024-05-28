
namespace Homework_13_1;

public class PluginManager
{
    private IPlugin CalculatorPlugin;
    private IPlugin GreetingsPlugin;
    public void LoadPlugin(IPlugin plugin)
    {

        if (plugin is CalculatorPlugin)
            CalculatorPlugin = plugin;
        else
            GreetingsPlugin = plugin;
    }

    public void ExecutePlugins()
    {
        CalculatorPlugin.Execute();
        GreetingsPlugin.Execute();
    }
}