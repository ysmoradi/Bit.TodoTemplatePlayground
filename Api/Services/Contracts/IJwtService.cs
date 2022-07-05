using Bit.TodoTemplatePlayground.Api.Models.Account;
using Bit.TodoTemplatePlayground.Shared.Dtos.Account;

namespace Bit.TodoTemplatePlayground.Api.Services.Contracts;

public interface IJwtService
{
    Task<SignInResponseDto> GenerateToken(User user);
}
