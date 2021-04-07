using System.Composition;

namespace MefExample.Simple.Main.Model
{
    [Export(typeof(Foo))]
    public class Foo : IModel
    {
        public string Content => "Foo";
    }
}