using System;
using System.Composition;
using MefExample.Core.Module;

namespace MefExample.Module.HelloWorld
{
    [Export(typeof(IModule))]
    public class SumModule : IModule
    {
        public string ModuleName { get; } = "Sum";

        public void ExplainUsage()
        {
            Console.WriteLine("Module: Sum");
            Console.WriteLine("Usage: Perform Addition of x + y and return result ");
            Console.WriteLine("1st input - x");
            Console.WriteLine("2nd input - y");
        }

        public void Run(params string[] args)
        {
            if (args.Length < 2)
            {
                Console.WriteLine("Invalid Inputs.");
            }

            int x, y;
            Int32.TryParse(args[0], out x);
            Int32.TryParse(args[1], out y);
            Console.WriteLine($"{x} + {y} = {x+y}");
        }
    }
}
