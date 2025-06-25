using WebapiScaffold.Data;
using WebapiScaffold.Models;

namespace WebapiScaffold.Repositories.Abstract
{
    public interface IUserRepository
    {
        Task<UserModel> GetByIdAsync(string id);
    }
}
