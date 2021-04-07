using System;
using System.Composition;
using MefExample.Simple.Main.Model;

namespace MefExample.Simple.Main
{
    [Export(typeof(SayFoo))]
    [Export(typeof(ISayWord))]
    public class SayFoo : ISayWord
    {
        private readonly Foo _foo;

        [ImportingConstructor]
        public SayFoo(Foo foo)
        {
            _foo = foo;
        }

        public void Print()
        {
            Console.WriteLine(_foo.Content);
        }
    }
}