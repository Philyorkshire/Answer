using Answer.Domain;
using Answer.Web.Models;

using AutoMapper;

namespace Answer.Web.AutoMapperProfiles
{
    public class PersonProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Person, PersonEditViewModel>();
            Mapper.CreateMap<PersonEditViewModel, Person>();
        }
    }
}