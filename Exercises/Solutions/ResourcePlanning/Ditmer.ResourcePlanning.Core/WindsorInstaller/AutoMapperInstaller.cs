using AutoMapper;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace Ditmer.ResourcePlanning.Core.WindsorInstaller
{
    public class AutoMapperInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            MappingConfiguration.Configure();

            container.Register(
                Component.For<IMappingEngine>()
                    .Instance(Mapper.Engine)
                );
        }
    }
}