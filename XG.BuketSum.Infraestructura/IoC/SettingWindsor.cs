using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace XG.BuketSum.Infraestructura.IoC
{
    public class SettingWindsor : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Install(
                new BucketSum.Business.IoC.SettingWindsor(),
                new BuketSum.Common.IoC.SettingWindsor()
            );
        }
    }
}
