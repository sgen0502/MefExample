using System;
using System.Collections.Generic;
using System.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MefExample.Shared.DI
{
    public class DependencyContainer
    {
        private static CompositionHost _container;
        private static DependencyContainer _instance;
        private DependencyContainer(params Type[] types)
        {
            var assemblies = types.Select(t => t.GetTypeInfo().Assembly);
            var configuration = new ContainerConfiguration()
                .WithAssemblies(assemblies);

            _container = configuration.CreateContainer();
        }

        public static void BuildDependency(params Type[] types)
        {
            if (_instance == null) _instance = new DependencyContainer(types);
        }

        public static T GetExportedValue<T>() => _container.GetExport<T>();

        public static T GetExportedValue<T>(string contractName) => _container.GetExport<T>(contractName);

        public static IEnumerable<T> GetExportedValues<T>() => _container.GetExports<T>();

        public static IEnumerable<T> GetExportedValues<T>(string contractName) => _container.GetExports<T>(contractName);
    }
}
