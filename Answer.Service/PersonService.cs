using System.Linq;
using System.Collections.Generic;

using Answer.Data;
using Answer.Domain;
using Answer.Service.Base;

namespace Answer.Service
{
    public class PersonService : EntityService<Person>, IPersonService
    {
        private readonly AnswerContext _context;
        private readonly IColourService _colourService;

        public PersonService(AnswerContext context, IColourService colourService) : base(context)
        {
            _colourService = colourService;
            _context = context;
        }

        public void UpdatePersonPreferences(int personId, bool isAuthorised, bool isEnabled, List<int> colourIds)
        {
            var person = _context.People.Find(personId);

            person.IsAuthorised = isAuthorised;
            person.IsEnabled = isEnabled;

            _context.SaveChanges();
            SetPersonColours(personId, colourIds);
        }

        private void SetPersonColours(int personId, List<int> colourIds)
        {
            var person = GetOrCreate(personId);
            var colours = _colourService.GetAll();

            for (var x = 0; x < colours.Count(); x++)
            {
                var colour = _colourService.GetOrCreate(x);
            }

            _context.SaveChanges();
        }
    }
}
