using System;
using System.IO;
using System.Linq;
using MefExample.Core.Application;
using MefExample.Core.Module;
using MefExample.Module.HelloWorld;
using MefExample.Module.Help;
using MefExample.Shared.DI;

namespace MefExample.Application
{
    class Application : IApplication
    {
        public void Run(params string[] args)
        {
            // Gather All Dependency Injection catalog here.
            DependencyContainer.BuildDependency(typeof(HelloWorldModule), typeof(HelpModule));
            var modules = DependencyContainer.GetExportedValues<IModule>();

            // When there is no input specified show Help option
            if (args.Length == 0)
            {
                var helpModule = DependencyContainer.GetExportedValue<IModule>("Help");
                helpModule.Run();
                return;
            }

            var runningModule = modules.FirstOrDefault(m => m.ModuleName.Equals(args[0]));
            if (runningModule != null)
            {
                runningModule.Run(args.Skip(1).ToArray());
            }
            else
            {
                Console.WriteLine("Can not find specified module.");
            }
        }
    }
}
