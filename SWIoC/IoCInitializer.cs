using SimpleInjector;
using SWDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SWIoC
{
    public class IoCInitializer
    {
        public static void Initialize(Container container, Lifestyle lifestyle)
        {
            var interfacesBusiness = GetInterfacesBusiness();
            var interfacesRepository = GetInterfacesRepository();

            var typesBusiness = GetTypesBusiness();
            var typesRepository = GetTypesRepository();

            Register(interfacesBusiness, typesBusiness, container, lifestyle);
            Register(interfacesRepository, typesRepository, container, lifestyle);

            container.Register<SWEntities>(lifestyle);
        }

        #region Private Methods

        private static void Register(IEnumerable<Type> interfaces, IEnumerable<Type> types, Container container, Lifestyle lifestyle)
        {
            foreach (var @interface in interfaces)
            {
                var type = types.Where(item => item.Name == @interface.Name.Substring(1)).FirstOrDefault();
                if (type != null)
                {
                    container.Register(@interface, type, lifestyle);
                }
            }
        }

        private static IEnumerable<Type> GetInterfacesBusiness()
        {
            return Assembly.Load("SWDomain").GetTypes().Where(type => type.Namespace == "SWDomain.Interfaces.Business" && type.IsInterface);
        }

        private static IEnumerable<Type> GetTypesBusiness()
        {
            return Assembly.Load("SWBusiness").GetTypes().Where(type => type.IsClass && !type.IsAbstract && type.GetCustomAttribute<CompilerGeneratedAttribute>() == null);
        }

        private static IEnumerable<Type> GetInterfacesRepository()
        {
            return Assembly.Load("SWDomain").GetTypes().Where(type => type.Namespace == "SWDomain.Interfaces.Repository" && type.IsInterface);
        }

        private static IEnumerable<Type> GetTypesRepository()
        {
            return Assembly.Load("SWRepository").GetTypes().Where(type => type.IsClass && !type.IsAbstract && type.GetCustomAttribute<CompilerGeneratedAttribute>() == null);
        }

        #endregion
    }
}
