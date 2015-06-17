using Ninject.Modules;

namespace Answer.Service.Infrastructure
{
    public class NinjectServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IPersonService>().To<PersonService>();
        }
    }
}