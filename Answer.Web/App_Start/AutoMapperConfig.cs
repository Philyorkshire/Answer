using Answer.Web.AutoMapperProfiles;
using AutoMapper;

namespace Answer.Web
{
    public static class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(
                cfg =>
                {
                    cfg.AddProfile(new PersonProfile());
                });
        }
    }
}