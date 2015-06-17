using Answer.Data;
using Answer.Domain;
using Answer.Service.Base;

namespace Answer.Service
{
    public class PersonService : EntityService<Person>, IPersonService
    {
        public PersonService(AnswerContext context) : base(context) {}
    }
}
