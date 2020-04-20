using Autofac;
using Business.Interfaces;
using Business.Services;
using Persistence.Repositories;

namespace IoC
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DebtRepository>().As<IDebtRepository>();
            builder.RegisterType<DebtService>().As<IDebtService>();
        }
    }
}
