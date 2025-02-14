using NuGet.Frameworks;
using UserAPI;
using UserAPI.UserRepo;

namespace UserAPI_Tests
{
    public class UserOps_Test
    {
        private readonly UserOps _userOps;

        public UserOps_Test()
        {
            _userOps = new UserOps();
        }

        [Theory]
        [InlineData(10, true)]
        [InlineData(100, false)]
        public async Task GetUserById_ExpectedResult(int id, bool userExist)
        {
            var data = await _userOps.GetUserByIdAsync(id);
            if (userExist)
            {
                Assert.NotNull(data);
                Assert.Equal(id, data.Id);
            }
            else
            {
                Assert.Null(data);
            }
        }

        [Fact]
        public async Task GetAllUsersAsync_ReturnsAllUsers()
        {
            var data = await _userOps.GetAllUsersAsync();
            Assert.NotNull(data);
            Assert.Equal(3,data.Count());
        }

        [Fact]
        public async Task AddUserAsync_AddsUserCorrectly()
        {
            User newUser = new User() { Id = 40, Name = "Rohit", Email = "Rohit@IVP.in" };
            await _userOps.AddUserAsync(newUser);
            var data = await _userOps.GetUserByIdAsync(newUser.Id);
            Assert.NotNull(data);
            Assert.Equal(data.Id, newUser.Id);
            Assert.Equal(data.Email, newUser.Email);
            Assert.Equal(data.Name, newUser.Name);
        }

        [Fact]
        public async Task UpdateUserAsync_UpdatesUserCorrectly()
        {
            var UpdatedUser = new User() { Id = 10, Name = "Nikhil", Email = "Nik@IVP.in" };
            await _userOps.UpdateUserAsync(UpdatedUser);
            var data = await _userOps.GetUserByIdAsync(UpdatedUser.Id);
            Assert.NotNull(data);
            Assert.Equal(data.Name, UpdatedUser.Name);
            Assert.Equal(data.Email, UpdatedUser.Email);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        public async Task DeleteUserAsync_DeletesUserCorrectly(int userId)
        {
            //var userId = 10;
            await _userOps.DeleteUserAsync(userId);
            var data = await _userOps.GetUserByIdAsync(userId);
            Assert.Null(data);
        }
    }
}