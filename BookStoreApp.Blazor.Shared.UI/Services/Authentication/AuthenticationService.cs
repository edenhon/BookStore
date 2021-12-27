using Blazored.LocalStorage;
using BookStoreApp.Blazor.Shared.UI.Providers;
using BookStoreApp.Blazor.Shared.UI.Services.Base;
using Microsoft.AspNetCore.Components.Authorization;

namespace BookStoreApp.Blazor.Shared.UI.Services.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IClient httpClient;
        private readonly ILocalStorageService localStorage;
        private readonly AuthenticationStateProvider authenticationStateProvider;

        public AuthenticationService(IClient httpClient, ILocalStorageService localStorage, AuthenticationStateProvider authenticationStateProvider)
        {
            this.httpClient = httpClient;
            this.localStorage = localStorage;
            this.authenticationStateProvider = authenticationStateProvider;
        }
        public async Task<bool> AuthenticateAsync(LoginUserDto loginModel)
        {
            try
            {
                var response = await httpClient.LoginAsync(loginModel);

                //Store Token
                await localStorage.SetItemAsync("accessToken", response.Token);


                //Change auth sate of app
                await ((ApiAuthenticationStateProvider)authenticationStateProvider).LoggedIn();

                return true;
            }
            catch (ApiException ex)
            {
                return false;
            }

        }

        public async Task Logout()
        {
            await ((ApiAuthenticationStateProvider)authenticationStateProvider).LoggedOut();
        }
    }
}
