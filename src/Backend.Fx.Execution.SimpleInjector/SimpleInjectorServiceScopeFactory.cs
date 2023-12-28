using Microsoft.Extensions.DependencyInjection;
using SimpleInjector;
using SimpleInjector.Lifestyles;

namespace Backend.Fx.Execution.SimpleInjector
{
    public class SimpleInjectorServiceScopeFactory : IServiceScopeFactory
    {
        private readonly Container _container;

        public SimpleInjectorServiceScopeFactory(Container container)
        {
            _container = container;
        }
        public IServiceScope CreateScope()
        {
            return new SimpleInjectorServiceScope(AsyncScopedLifestyle.BeginScope(_container));
        }
    }
}