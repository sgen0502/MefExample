using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MefExample.Shared.DI
{
    public class DirectoryCatalogContainer
    {
        private static CompositionContainer _container;
        private static DirectoryCatalogContainer _instance;
        private DirectoryCatalogContainer(string dir)
        {
            var mefs = new DirectoryCatalog(dir, "*.dll");
            var catalogs = new AggregateCatalog(mefs);
            _container = new CompositionContainer(catalogs);
     
        }

        public static void BuildDependency(string dir)
        {
            if (_instance == null) _instance = new DirectoryCatalogContainer(dir);
        }

        public static T GetExportedValue<T>() => _container.GetExportedValue<T>();

        public static T GetExportedValue<T>(string contractName) => _container.GetExportedValue<T>(contractName);

        public static IEnumerable<T> GetExportedValues<T>() => _container.GetExportedValues<T>();

        public static IEnumerable<T> GetExportedValues<T>(string contractName) => _container.GetExportedValues<T>(contractName);
    }
}
