using System;
using System.Reflection;
using MefExample.Shared.DI;

namespace MefExample.Simple.Main
{
    class Program
    {
        static void Main(string[] args)
        {
            DependencyContainer.BuildDependency(typeof(Program));
            
            // Single Export
            var sayBar = DependencyContainer.GetExportedValue<SayBar>();
            sayBar.Print();

            var sayFoo = DependencyContainer.GetExportedValue<SayFoo>();
            sayFoo.Print();

            // Labeled Export
            // Labeled export resides on different space than default export
            // Therefore, you won't see default export for ISayWord.
            var sayWords = DependencyContainer.GetExportedValue<ISayWord>("Word");
            sayWords.Print();

            // Multi Export
            // SayFoo and SayBar is exported as ISayWord so can be gathered by getting export for ISayWord
            var foobar = DependencyContainer.GetExportedValues<ISayWord>();
            foreach (var sayWord in foobar)
            {
                sayWord.Print();
            }

            Console.ReadKey();
        }
    }
}
