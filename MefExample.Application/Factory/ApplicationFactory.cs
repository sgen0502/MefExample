using MefExample.Core.Application;

namespace MefExample.Application.Factory
{
    public class ApplicationFactory
    {
        public static IApplication CreateApplication()
        {
            return new Application();
        }
    }
}