using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Management.Automation.Runspaces;

namespace Copper_Constrained
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UI.Ui.Banner();
            NoCLM();
        }
        
        
        public static void NoCLM()
        {
            bool OutString = true;
            //create a powershell object
            var ps = PowerShell.Create();
            //create a new runspace
            ps.Runspace = RunspaceFactory.CreateRunspace();
            //open the runspace
            ps.Runspace.Open();
            //set the powershell object to run the user input
            Console.WriteLine("Enter your command: ");
            while (true)
            {
                Console.Write("Copper > ");
                string input = Console.ReadLine();
                if (input == "exit")
                {
                    ps.Runspace.Close();
                    Environment.Exit(0);
                }
                else
                {
                    //adds command and checks to the powershell object to get a good verbose output from the command
                    ps.AddScript(input);
                    if (OutString) { ps.AddCommand("Out-String"); }
                    PSDataCollection<object> results = new PSDataCollection<object>();
                    ps.Streams.Error.DataAdded += (sender, e) =>
                    {
                        Console.WriteLine("Error");
                        foreach (ErrorRecord er in ps.Streams.Error.ReadAll())
                        {
                            results.Add(er);
                        }
                    };
                    ps.Streams.Verbose.DataAdded += (sender, e) =>
                    {
                        foreach (VerboseRecord vr in ps.Streams.Verbose.ReadAll())
                        {
                            results.Add(vr);
                        }
                    };
                    ps.Streams.Debug.DataAdded += (sender, e) =>
                    {
                        foreach (DebugRecord dr in ps.Streams.Debug.ReadAll())
                        {
                            results.Add(dr);
                        }
                    };
                    ps.Streams.Warning.DataAdded += (sender, e) =>
                    {
                        foreach (WarningRecord wr in ps.Streams.Warning)
                        {
                            results.Add(wr);
                        }
                    };
                    ps.Invoke(null, results);
                    string output = string.Join(Environment.NewLine, results.Select(R => R.ToString()).ToArray());
                    ps.Commands.Clear();
                    Console.WriteLine(output);
                }
            }
        }
    }
}
