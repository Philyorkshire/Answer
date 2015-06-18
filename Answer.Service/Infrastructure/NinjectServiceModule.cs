using Answer.Data;
using Ninject.Modules;
using Ninject.Web.Common;

namespace Answer.Service.Infrastructure
{
    public class NinjectServiceModule : NinjectModule
    {
        public override void Load()
        {
            Bind<AnswerContext>().ToSelf().InRequestScope();
            Bind<IPersonService>().To<PersonService>().InRequestScope();
            Bind<IColourService>().To<ColourService>().InRequestScope();
        }
    }
}