using Ninject.Modules;
using PostsharpAndInjection.TheCode.Services;

namespace PostsharpAndInjection.TheCode
{
    public class SiteModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ILog>().To<DefaultLog>();
        }
    }
}