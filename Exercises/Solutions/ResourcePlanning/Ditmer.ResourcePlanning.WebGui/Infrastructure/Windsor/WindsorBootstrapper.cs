using System;
using System.Data.Entity;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.Windsor.Installer;
using Ditmer.ResourcePlanning.Core.Models;
using Ditmer.ResourcePlanning.Core.WindsorInstaller;

namespace Ditmer.ResourcePlanning.WebGui.Infrastructure.Windsor
{
    public class WindsorBootstrapper : IDisposable
    {
        private readonly IWindsorContainer _container;

        public WindsorBootstrapper()
        {
            _container = new WindsorContainer();
        }

        public IWindsorContainer Container
        {
            get { return _container; }
        }

        public void Setup(IWindsorInstaller controllerProjectInstaller)
        {
            Container.Install(FromAssembly.Containing<MediatorInstaller>());
            Container.Install(controllerProjectInstaller);

            Container.Register(
                Component.For<DbContext>()
                    .ImplementedBy<ResourcePlanningDbContext>()
                    .DependsOn(Dependency.OnValue<string>("ResourcePlanningDatabaseConnectionString"))
                    .LifestylePerWebRequest()
                );
        }

        public void Dispose()
        {
            Container?.Dispose();
        }
    }
}