using WebapiScaffold.Data;
using WebapiScaffold.Models;
using WebapiScaffold.Repositories.Abstract;

namespace WebapiScaffold.Repositories.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;

        public UserRepository(UserDbContext context)
        {
            _context = context;
        }

        public async Task<UserModel> GetByIdAsync(string id)
        {
            var user = await _context.UserInfo.FindAsync(id);
            if (user == null)
            {
                throw new InvalidOperationException($"User with ID {id} not found.");
            }
            return user;
        }
    }
}
