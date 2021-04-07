using System;
using System.Collections.Generic;
using System.Text;

namespace MefExample.Core.Module
{
    public interface IModule
    {
        string ModuleName { get; }
        void ExplainUsage();
        void Run(params string[] args);
    }
}
