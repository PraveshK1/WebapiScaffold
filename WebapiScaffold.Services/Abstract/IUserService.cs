using WebapiScaffold.DTOs;

namespace WebapiScaffold.Services.Abstract
{
    public interface IUserService
    {
        Task<UserDTO?> GetUserByIdAsync(string id);
    }
}
