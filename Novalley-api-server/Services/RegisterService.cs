using Novalley_api_server.Interfaces;
using Microsoft.AspNetCore.Identity;
using Novalley_api_server.Models;
using Novalley_api_server.DTOs;

namespace Novalley_api_server.Services
{
    public class RegisterService: IRegisterService
    {
        private readonly UserManager<User> _userManager;

        public RegisterService (UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> RegisterUserAsync(UserRegistrationDto userRegistrationDto)
        {
            var registerUser = new User
            {
                UserName = userRegistrationDto.Username,
                FullName = userRegistrationDto.FullName,
                AvartarURL = string.Empty,
                DateOfBirth = userRegistrationDto.DateOfBirth
            };

            Console.WriteLine($"Username: {userRegistrationDto.Username}");
            Console.WriteLine($"Password: {userRegistrationDto.Password}");
            Console.WriteLine($"FullName: {userRegistrationDto.FullName}");
            Console.WriteLine($"DateOfBirth: {userRegistrationDto.DateOfBirth}");

            var registerResult = await _userManager.CreateAsync(registerUser, userRegistrationDto.Password);

            return registerResult;
        }

    }
}
