using System;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using BlazorWASMProject.Models;
using BlazorWASMProject.Services.Interfaces;
using Microsoft.AspNetCore.Components.Authorization;

namespace BlazorWASMProject.Services
{
    public class CustomStateProvider : AuthenticationStateProvider
    {
        private readonly IAuthService api;
        private CurrentUser _currentUser;
        private ILocalStorageService LocalStorageService;

        public CustomStateProvider(IAuthService api, ILocalStorageService localStorageService)
        {
            LocalStorageService = localStorageService;
            this.api = api;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var identity = new ClaimsIdentity();
            try
            {
                var userInfo = await GetCurrentUser().ConfigureAwait(false);
                if (userInfo.IsAuthenticated)
                {
                    var claims =
                        new[] {new Claim(ClaimTypes.Name, _currentUser.UserName)}.Concat(
                            _currentUser.Claims.Select(c => new Claim(c.Key, c.Value)));
                    identity = new ClaimsIdentity(claims, "Server authentication");
                }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine("Request failed:" + ex.ToString());
            }


            return new AuthenticationState(new ClaimsPrincipal(identity));
        }
        
        private async Task<CurrentUser> GetCurrentUser()
        {
         //   if (_currentUser != null && _currentUser.IsAuthenticated) return _currentUser;
            _currentUser = await api.CurrentUserInfo();
            return _currentUser;
        }
        public async Task Logout()
        {
            await api.Logout();
            _currentUser = null;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        public async Task Login(LoginRequest loginParameters)
        {
            await api.Login(loginParameters);
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
        public async Task Register(RegisterRequest registerParameters)
        {
            await api.Register(registerParameters);
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
    }
}