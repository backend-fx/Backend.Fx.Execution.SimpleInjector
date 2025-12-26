using Microsoft.Extensions.DependencyInjection;
using SimpleInjector.Lifestyles;

namespace Backend.Fx.Execution.SimpleInjector
{
    public class SimpleInjectorServiceScopeFactory : IServiceScopeFactory
    {
        private readonly SimpleInjectorCompositionRoot _compositionRoot;
        
        public SimpleInjectorServiceScopeFactory(SimpleInjectorCompositionRoot compositionRoot)
        {
            _compositionRoot = compositionRoot;
        }
        
        public IServiceScope CreateScope()
        {
            return new SimpleInjectorServiceScope(AsyncScopedLifestyle.BeginScope(_compositionRoot.Container));
        }
    }
}