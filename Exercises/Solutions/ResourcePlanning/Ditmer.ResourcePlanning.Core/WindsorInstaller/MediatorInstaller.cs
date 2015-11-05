using System;
using System.Collections.Generic;
using System.IO;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using MediatR;

namespace Ditmer.ResourcePlanning.Core.WindsorInstaller
{
    public class MediatorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IMediator>().ImplementedBy<Mediator>());
            container.Register(
                  Classes.FromThisAssembly()
                    .BasedOn(typeof(IRequestHandler<,>))
                    .WithService
                    .AllInterfaces()
                    .LifestylePerWebRequest());

            container.Register(Component.For<TextWriter>().Instance(Console.Out));
            container.Kernel.AddHandlersFilter(new ContravariantFilter());
            container.Register(Component.For<SingleInstanceFactory>().UsingFactoryMethod<SingleInstanceFactory>(k => t => k.Resolve(t)));
            container.Register(Component.For<MultiInstanceFactory>().UsingFactoryMethod<MultiInstanceFactory>(k => t => (IEnumerable<object>)k.ResolveAll(t)));
        }
    }
}