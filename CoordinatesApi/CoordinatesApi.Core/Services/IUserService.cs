using System.Threading.Tasks;
using CoordinatesApi.Core.Models.Auth;

namespace CoordinatesApi.Core.Services;

public interface IUserService
{
    Task CreateUserAsync(RegisterModel registerModel);
    Task ValidateCredentialsAsync(LoginModel loginModel);
}