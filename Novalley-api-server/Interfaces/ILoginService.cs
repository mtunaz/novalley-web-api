using Novalley_api_server.DTOs;

namespace Novalley_api_server.Interfaces
{
    public interface ILoginService
    {
        public Task<bool> UserLoginAsync(LoginCredentialDto loginCredential);
        Task LogoutAsync();
    }
}
