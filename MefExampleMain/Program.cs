using System;
using MefExample.Application;
using MefExample.Application.Factory;
using MefExample.Shared.DI;

namespace MefExampleMain
{
    class Program
    {
        static void Main(string[] args)
        {
            ApplicationFactory.CreateApplication().Run(args);
        }
    }
}