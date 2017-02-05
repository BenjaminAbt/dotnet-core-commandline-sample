using System;
using Microsoft.Extensions.CommandLineUtils;

class Program
{

    // the cli always should have a return code
    // so change void return to int
    static int Main(string[] args)
    {
        // Define app which is required for CLI
        var app = new CommandLineApplication
        {
            Name = "CLI Options Sample by Benjamin Abt",
            Description = "This app shows how the NuGet package Microsoft.Framework.CommandLineUtils",
            FullName = "CLI Options Sample by Benjamin Abt - www.schwabencode.com"
        };

            // Enable help Options
            app.HelpOption("-?|-h|--help"); // accessable with 3 different parameter names

            // Register Options
            var name = app.Option("--name|-n", "This is the parameter 'name'. You can use --name or the shortcut -n", CommandOptionType.SingleValue);
            var options = app.Option("--options|-o", "This is the parameter 'option'. You can pass multiple values", CommandOptionType.MultipleValue);
            var force = app.Option("--force", "This is the parameter 'firce' without any other shurtcut or value. ", CommandOptionType.NoValue);


        // define what happens on Execute
        app.OnExecute(() =>
        {
            // Show help
            app.ShowHelp();

            // Output
            if (name.HasValue())
            {
                Console.WriteLine($"The parameter 'name' was used and the passed value is: '{name.Value()}'");
            }
            else
            {
                Console.WriteLine($"The parameter 'name' was not used.");
            }

            if (options.HasValue())
            {
                Console.WriteLine($"The parameter 'option' was used and has {options.Values.Count} values:");
                foreach(var opt in options.Values)
                {
                    Console.WriteLine($" > {opt}'");
                }
            }
            else
            {
                Console.WriteLine($"The parameter 'options' was not used.");
            }

            
            if (force.HasValue())
            {
                Console.WriteLine($"The parameter 'force' was used.");
            }
            else
            {
                Console.WriteLine($"The parameter 'force' was not used.");
            }

            // give a return code
            // if anything is wrong return -1!
            return 0;
        });


        // run defined app
        return app.Execute(args);
    }
}