using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Moq;
using UserAPI;
using UserAPI.Controllers;
using UserAPI.UserRepo;

namespace UserAPI_Tests
{
    public class UsersController_Tests
    {
        private readonly UsersController _uc;
        private readonly Mock<IUser> _mockIUser;
        public UsersController_Tests()
        {
            _mockIUser = new Mock<IUser>();
            _uc = new UsersController(_mockIUser.Object);
        }

        [Fact]
        public async Task GetAllUsers_ReturnsOKResultWithListOfUsers()
        {
            //Arrange
            var users = new List<User>()
            {
                new User { Id = 10, Name = "Nikhil", Email = "Nikhil@IVP.in" },
                new User { Id = 20, Name = "Richa", Email = "Richa@IVP.in" },
                new User { Id = 30, Name = "Amit", Email = "Amit@IVP.in" }
            };

            _mockIUser.Setup(service => service.GetAllUsersAsync()).ReturnsAsync(users);

            var data = await _uc.GetAllUsers() as OkObjectResult;

            Assert.NotNull(data);
            Assert.Equal(200, data.StatusCode);
            Assert.Equal(users, data.Value);
        }

        [Theory]
        [InlineData(10, true)]
        [InlineData(100, false)]
        public async Task GetUserById_ReturnsExpectedResult(int userId, bool userExists)
        {
            var expectedUser = userExists ? new User() { Id = 10, Name = "Nikhil", Email = "Nikhil@IVP.in" } : null;
            _mockIUser.Setup(x => x.GetUserByIdAsync(userId)).ReturnsAsync(expectedUser);
            var data = await _uc.GetUserById(userId);
            if (userExists)
            {
                var info = Assert.IsType<OkObjectResult>(data);
                Assert.NotNull(info.Value);
                Assert.Equal(expectedUser.Id, ((User)info.Value).Id);
                Assert.Equal(expectedUser.Name, ((User)info.Value).Name);
                Assert.Equal(expectedUser.Email, ((User)info.Value).Email);
            }
            else
            {
                Assert.IsType<NotFoundResult>(data);
            } 
        }

        [Fact]
        public async Task AddUser_ReturnsCreatedAtActionResult()
        {
            User newUser = new User() { Id = 40, Name = "Vanshika", Email = "Vanshika@IVP.in"};

            var data = await _uc.AddUser(newUser) as CreatedAtActionResult;

            Assert.NotNull(data);
            Assert.Equal(201, data.StatusCode);
            Assert.Equal("GetUserById", data.ActionName);
            Assert.Equal(newUser.Id, ((User)data.Value).Id);
        }

        [Fact]
        public async Task UpdateUser_ReturnsNoContent()
        {
            User updatedUser = new User() { Id = 10, Name = "Rohit", Email = "Rohit@IVP.in" };

            var data = await _uc.UpdateUser(10, updatedUser) as NoContentResult;
            Assert.NotNull(data);
            Assert.Equal(204, data.StatusCode);
        }

        [Fact]
        public async Task UpdateUserAsync_ReturnsBadRequest_WhenIdMismatch()
        {
            User updatedUser = new User() { Id = 1, Name = "Rohit", Email = "Rohit@IVP.in" };

            var data = await _uc.UpdateUser(10, updatedUser) as BadRequestResult;
            Assert.NotNull(data);
            Assert.Equal(400, data.StatusCode);
        }

        [Fact]
        public async Task DeleteUser_ReturnsNoContent()
        {
            var userId = 10;
            _mockIUser.Setup(x=> x.DeleteUserAsync(10)).Returns(Task.CompletedTask);

            var data = await _uc.DeleteUser(userId) as OkObjectResult;
            Assert.NotNull(data);
            Assert.Equal(200, data.StatusCode);
        }
    }
}
