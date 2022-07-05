using Bit.TodoTemplatePlayground.Api.Models.Account;
using Bit.TodoTemplatePlayground.Shared.Dtos.Account;

namespace Bit.TodoTemplatePlayground.Api.Mappers;

public class AccountMapperConfiguration : Profile
{
    public AccountMapperConfiguration()
    {
        CreateMap<Role, RoleDto>().ReverseMap();

        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<User, EditUserDto>().ReverseMap();
        CreateMap<User, SignUpRequestDto>()
            .ReverseMap();
    }
}
