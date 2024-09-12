using Autofac;
using Microsoft.EntityFrameworkCore;
using Persistance.Contexts;
using Services.Implementation.Registration;



namespace Persistance
{
    public class PersistenceRegisterModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           base.Load(builder);


          

            builder.RegisterAssemblyModules(this.GetType().Assembly)
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();

            

            builder.RegisterType<DataContext>()
                .As<DbContext>()
                .InstancePerLifetimeScope();
        }

    }
}
