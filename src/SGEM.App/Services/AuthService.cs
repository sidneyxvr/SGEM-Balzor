using Blazor.Extensions.Storage;
using SGEM.App.ViewModels.Auth;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SGEM.App.Services
{
    public class AuthService : Service
    {
        public AuthService(HttpClient httpClient, LocalStorage localStorage) : base(httpClient, localStorage, "auth")
        {
        }

        public async Task Login(LoginViewModel login)
        {
            Console.WriteLine("Teste");
            var response = await Post<LoginResponseViewModel>(login);
            await _localStorage.SetItem<string>("Authorization", response.AccessToken);
            Console.WriteLine(response.AccessToken);
        }

        public async Task Register(RegisterUserViewModel register)
        {
            await Post<RegisterUserViewModel>(register);
        }
        
    }
}
