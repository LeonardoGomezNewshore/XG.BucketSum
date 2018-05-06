using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;

namespace XG.BucketSum.Service.Ioc
{
    public class SettingWindsor : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Install(
                new BuketSum.Common.IoC.SettingWindsor(),
                new Business.IoC.SettingWindsor()
            );
        }
    }
}