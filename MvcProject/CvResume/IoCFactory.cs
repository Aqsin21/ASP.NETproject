using Autofac;
using Persistance;
using Autofac.Extensions.DependencyInjection;
using Services.Implementation.Registration;

namespace CvResume
{
    public class IoCFactory : AutofacServiceProviderFactory
    {
        public IoCFactory()
            : base(Register)
        {

        }

        private static void Register(ContainerBuilder builder)
        {
            builder.RegisterModule<PersistenceRegisterModule>();


            builder.RegisterModule<ServiceRegisterModule>();
        }
    }
}
