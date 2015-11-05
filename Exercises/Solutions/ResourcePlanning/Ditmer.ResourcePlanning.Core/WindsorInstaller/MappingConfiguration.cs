using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using AutoMapper;

namespace Ditmer.ResourcePlanning.Core.WindsorInstaller
{
    public static class MappingConfiguration
    {
        public static void Configure(List<Assembly> assemblies)
        {
            Mapper.Initialize(x => GetConfiguration(assemblies, Mapper.Configuration));
        }

        public static void Configure()
        {
            var assemblies = new List<Assembly> { typeof(MappingConfiguration).Assembly };

            Mapper.Initialize(x => GetConfiguration(assemblies, Mapper.Configuration));
        }

        private static void GetConfiguration(IEnumerable<Assembly> assemblies, IConfiguration configuration)
        {
            var types = new List<Type>();

            foreach (var thisAssembly in assemblies)
            {
                types.AddRange(thisAssembly.GetTypes());
            }

            var profiles = types.Where(x => typeof(Profile).IsAssignableFrom(x));

            foreach (var profile in profiles)
            {
                configuration.AddProfile(Activator.CreateInstance(profile) as Profile);
            }

            Mapper.AssertConfigurationIsValid();
        }
    }
}
