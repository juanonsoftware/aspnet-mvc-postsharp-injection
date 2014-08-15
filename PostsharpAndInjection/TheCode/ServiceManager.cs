using Ninject;
using PostsharpAndInjection.TheCode.Services;
using System;

namespace PostsharpAndInjection.TheCode
{
    public class ServiceManager
    {
        [Inject]
        public ILog Log { get; set; }

        private static readonly Lazy<ServiceManager> Lazy = new Lazy<ServiceManager>(() => new ServiceManager());

        private ServiceManager()
        {
        }

        public static ServiceManager Instance
        {
            get { return Lazy.Value; }
        }
    }
}