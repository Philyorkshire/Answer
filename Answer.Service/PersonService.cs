using System.Collections.Generic;

using Answer.Data;
using Answer.Domain;
using Answer.Service.Base;

namespace Answer.Service
{
    public class PersonService : EntityService<Person>, IPersonService
    {
        private readonly IColourService _colourService;

        public PersonService(AnswerContext context, IColourService colourService) : base(context)
        {
            _colourService = colourService;
        }

        public void UpdatePersonPreferences(int personId, bool isAuthorised, bool isEnabled, List<int> colourIds)
        {
            var person = GetById(personId);
            person.IsAuthorised = isAuthorised;
            person.IsEnabled = isEnabled;
            Update(person);

            SetPersonColours(personId, colourIds);
        }

        private void SetPersonColours(int personId, List<int> colourIds)
        {
            var person = GetById(personId);
            person.FavouriteColours.Clear();

            for (var i = 0; i < colourIds.Count; i++)
            {
                var colour = _colourService.GetById(colourIds[i]);
                colour.People.Add(person);
            }

            Update(person);
        }
    }
}
