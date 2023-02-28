using FactoryDesignPattern.AnimalManager;
using FactoryDesignPattern.AnimalManager.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Configuration
{
    internal class ConfigureServices
    {
        public static IServiceProvider ServiceProvider { get; set; }

        internal static void Configure()
        {
            
                var services = new ServiceCollection();

                #region [User Services]

                services.AddScoped<IAnimalFactory, AnimalRequestHandlerFactory>();                
                
                Assembly.GetAssembly(typeof(AnimalRequestHandlerFactory))
                        .GetTypes()
                        .Where(a => a.Name.EndsWith("RequestHandler"))
                        .Select(a => new { assignedType = a, serviceTypes = a.GetInterfaces().ToList() })
                        .ToList()
                        .ForEach(typesToRegister =>
                        {
                            typesToRegister.serviceTypes.ForEach(typeToRegister => services.AddScoped(typeToRegister, typesToRegister.assignedType));
                        });                

                #endregion

                ServiceProvider = services.BuildServiceProvider();            
        }

        internal static T GetService<T>() where T : class
        {
            return (T)ServiceProvider.GetService(typeof(T));
        }
    }
}
