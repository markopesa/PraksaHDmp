using AutoMapper;
using PraksaHDmp.Data;
using PraksaHDmp.Models;

namespace PraksaHDmp.Configuration
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<User,UserVM>().ReverseMap();
            CreateMap<UserCreateVM, User>().ReverseMap();
            CreateMap<UserEditVM, User>().ReverseMap();
            CreateMap<UserInactiveVM, User>().ReverseMap();

        }
    }
}
