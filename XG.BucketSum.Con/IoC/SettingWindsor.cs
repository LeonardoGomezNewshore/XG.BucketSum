using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Castle.MicroKernel.SubSystems.Configuration;

namespace XG.BucketSum.Con.IoC
{
    public class SettingWindsor : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Install(new BuketSum.Common.IoC.SettingWindsor(),
                new Business.IoC.SettingWindsor());
        }
    }
}
