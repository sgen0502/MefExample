using System;
using System.Composition;
using MefExample.Core.Module;

namespace MefExample.Module.HelloWorld
{
    [Export(typeof(IModule))]
    public class EchoModule : IModule
    {
        public string ModuleName { get; } = "Echo";

        public void ExplainUsage()
        {
            Console.WriteLine("Module: Echo");
            Console.WriteLine("Usage:");
            Console.WriteLine("1st input - Echos back this input");
        }

        public void Run(params string[] args)
        {
            Console.WriteLine($"You typed: {args[0]}");
        }
    }
}
