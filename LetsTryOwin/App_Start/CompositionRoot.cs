using LetsTryOwin.Domain;
using LightInject;

namespace LetsTryOwin
{
    internal class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IRandomNumberGenerator, RandomNumberGenerator>();
        }
    }
}