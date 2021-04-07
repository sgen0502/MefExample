using System.Composition;

namespace MefExample.Simple.Main.Model
{
    [Export(typeof(Bar))]
    public class Bar : IModel
    {
        public string Content => "Bar";
    }
}