using System.Collections.Generic;
using Answer.Domain;
using Answer.Service.Base;

namespace Answer.Service
{
    public interface IPersonService : IEntityService<Person>
    {
        void UpdatePersonPreferences(int personId, bool isAuthorised, bool isEnabled, List<int> colourIds);
    }
}
