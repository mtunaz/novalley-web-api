using Microsoft.AspNetCore.Identity;
using Novalley_api_server.DTOs;
using Novalley_api_server.Interfaces;
using Novalley_api_server.Models;

namespace Novalley_api_server.Services
{
    public class LoginService: ILoginService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public LoginService(SignInManager<User> signInManager, UserManager<User> userManager) 
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public async Task<bool> UserLoginAsync(LoginCredentialDto loginCredential)
        {
            var checkExistUser = await _userManager.FindByNameAsync(loginCredential.Username);
            if (checkExistUser == null)
            {
                return false;
            }

            var loginResult = await _signInManager.PasswordSignInAsync(checkExistUser, loginCredential.Password, isPersistent: true, lockoutOnFailure: false);

            return loginResult.Succeeded;

        }

        // Not completed yet
        public async Task LogoutAsync()
        {
            await _signInManager.SignOutAsync();
        }

    }
}
