using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using XG.BuketSum.Common.Helpers;

namespace XG.BuketSum.Common.IoC
{
    public class SettingWindsor : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<IFileDecorator>()
               .ImplementedBy<FileDecorator>().LifestyleTransient());

            container.Register(Component.For<IFileManager>()
                .ImplementedBy<FileManager>().LifestyleTransient());
        }
    }
}
