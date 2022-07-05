using Bit.TodoTemplatePlayground.Shared.Dtos.Account;

namespace Bit.TodoTemplatePlayground.App.Services.Contracts;

public interface IAuthenticationService
{
    Task SignIn(SignInRequestDto dto);

    Task SignOut();
}
