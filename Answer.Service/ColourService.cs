using Answer.Data;
using Answer.Domain;
using Answer.Service.Base;

namespace Answer.Service
{
    public class ColourService : EntityService<Colour>, IColourService
    {
        public ColourService(AnswerContext context) : base(context) {}
    }
}
