using System;
using System.Composition;
using MefExample.Core.Module;

namespace MefExample.Module.HelloWorld
{
    [Export(typeof(IModule))]
    public class HelloWorldModule : IModule
    {
        public string ModuleName { get; } = "HelloWorld";

        public void ExplainUsage()
        {
            Console.WriteLine("Module: HelloWorld");
            Console.WriteLine("Usage:");
            Console.WriteLine("- Does not take any argument");
        }

        public void Run(params string[] args)
        {
            Console.WriteLine("Hello World");
        }
    }
}
