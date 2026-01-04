using Modetour.DataAccess;
using Modetour.Extensions;
using Modetour.Repositories;

namespace Modetour.B2C.Package.Extensions
{
    public static class HostingExtensions
    {
        public static IServiceCollection AddAllDac(this IServiceCollection serviceCollection, string nameSpace = TypeExtension.DEFAULT_NAMESPACE, IEnumerable<Type> types = null, Type baseType = null)
        {
            types ??= TypeExtension.GetAllTypes(nameSpace, baseType);

            foreach (var type in types)
            {
                serviceCollection.AddScoped(typeof(IDbAccess), type);
            }
            return serviceCollection;
        }

        public static IServiceCollection AddAllRepository(this IServiceCollection serviceCollection, string nameSpace = TypeExtension.DEFAULT_NAMESPACE, IEnumerable<Type> types = null, Type baseType = null)
        {
            baseType ??= typeof(IRepository);
            types ??= TypeExtension.GetAllTypes(nameSpace, baseType);

            foreach (var type in types)
            {
                serviceCollection.AddScoped(type);
            }
            return serviceCollection;
        }
    }
}
