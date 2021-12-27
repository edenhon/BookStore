using BookStoreApp.Blazor.Shared.UI.Services.Base;

namespace BookStoreApp.Blazor.Shared.UI.Services.Authentication
{
    public interface IAuthenticationService
    {
        Task<bool> AuthenticateAsync(LoginUserDto loginModel);
        public Task Logout();
    }
}
