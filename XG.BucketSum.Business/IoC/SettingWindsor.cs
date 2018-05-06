using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XG.BucketSum.Business.Operations;
using XG.BucketSum.Business.Patterns.Facade;
using XG.BuketSum.Common.Helpers;

namespace XG.BucketSum.Business.IoC
{
    public class SettingWindsor : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IBucketSumFacade>()
                 .ImplementedBy<BucketSumFacade>()
                 .LifestyleTransient());

            container.Register(Component.For<IOperationsBucketSum>()
                .ImplementedBy<OperationsBucketSum>()
                .LifestyleTransient());
        }
    }
}
