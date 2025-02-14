
namespace UserAPI.UserRepo
{
    public class UserOps : IUser
    {
        private readonly List<User> _users;

        public UserOps()
        {
            _users = new List<User>()
            {
                new User { Id = 10, Name = "Nikhil", Email = "Nikhil@IVP.in" },
                new User { Id = 20, Name = "Richa", Email = "Richa@IVP.in" },
                new User { Id = 30, Name = "Amit", Email = "Amit@IVP.in" }
            };
        }
        public async Task AddUserAsync(User user)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(1000));
            _users.Add(user);
        }

        public async Task DeleteUserAsync(int userId)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(1000));
            var user = _users.Find(x => x.Id == userId);
            if (user != null)
            {
                _users.Remove(user);
            }
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(1000));
            return _users;
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(1000));
            return _users.FirstOrDefault(x => x.Id == userId);
        }

        public async Task UpdateUserAsync(User user)
        {
            await Task.Delay(TimeSpan.FromMilliseconds(1000));
            var data = _users.Find(x => x.Id == user.Id);
            if (data != null)
            {
                data.Name = user.Name;
                data.Email = user.Email;
            }
        }
    }
}
