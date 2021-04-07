using System.Composition;

namespace MefExample.Simple.Main.Model
{
    [Export(typeof(IModel))]
    public class Word : IModel
    {
        public string Content => "B";
    }
}