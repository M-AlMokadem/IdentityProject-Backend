using System;
using System.Threading.Tasks;
using IdentityProject.Models;

namespace IdentityProject.Services
{
    public interface IAuthService
    {
        Task<AuthModel> RegisterAysnc(RegisterModel model);
        Task<AuthModel> GetTokenAysnc(TokenRequestModel model);
        Task<string> AddRoleAsync(AddRoleModel model);
    }
}

