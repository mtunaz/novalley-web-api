using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Novalley_api_server.Controllers;
using Novalley_api_server.DTOs;

namespace Novalley_api_server.Interfaces
{
    public interface IRegisterService
    {
        public Task<IdentityResult> RegisterUserAsync(UserRegistrationDto userRegistrationDto);

    }
}
