using System.Composition;

namespace MefExample.Simple.Main.Model
{
    [Export(typeof(IModel))]
    public class WordA : IModel
    {
        public string Content => "A";
    }
}