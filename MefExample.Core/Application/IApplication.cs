using System;
using System.Collections.Generic;
using System.Text;

namespace MefExample.Core.Application
{
    public interface IApplication
    {
        void Run(params string[] args);
    }
}
