using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Infra.bus;
using Microsoft.Extensions.DependencyInjection;

namespace MicroRabbit.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domian Bus
            services.AddTransient<IEventBus, RabbitMQBus>();
        }
    }
}
