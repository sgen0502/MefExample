using System;
using System.Composition;
using MefExample.Simple.Main.Model;

namespace MefExample.Simple.Main
{
    [Export(typeof(SayBar))]
    [Export(typeof(ISayWord))]
    public class SayBar : ISayWord
    {
        private readonly Bar _bar;

        [ImportingConstructor]
        public SayBar(Bar bar)
        {
            _bar = bar;
        }

        public void Print()
        {
            Console.WriteLine(_bar.Content);
        }
    }
}