using MefExample.Core.Module;
using System;
using System.Collections.Generic;
using System.Composition;

namespace MefExample.Module.Help
{
    [Export("Help", typeof(IModule))]
    public class HelpModule: IModule
    {
        private readonly IEnumerable<IModule> _modules;

        [ImportingConstructor]
        public HelpModule([ImportMany]IEnumerable<IModule> modules)
        {
            _modules = modules;
        }

        public string ModuleName { get; } = "Help";
        public void ExplainUsage()
        {
            throw new NotImplementedException();
        }

        public void Run(params string[] args)
        {
            foreach (var module in _modules)
            {
                module.ExplainUsage();
                Console.WriteLine();
            }
        }
    }
}
