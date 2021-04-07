using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using MefExample.Simple.Main.Model;

namespace MefExample.Simple.Main
{
    [Export("Word", typeof(ISayWord))]
    public class SayWords : ISayWord
    {
        private readonly IEnumerable<IModel> _words;

        [ImportingConstructor]
        public SayWords([ImportMany] IEnumerable<IModel> words)
        {
            _words = words;
        }

        public void Print()
        {
            Console.WriteLine(string.Join(",", _words.Select(w => w.Content)));
        }
    }
}