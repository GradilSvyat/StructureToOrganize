using System;
using System.Resources;
using System.Threading.Tasks;
using Xunit;
using StructureToOrganize.Controllers;
using StructureToOrganize.Models;
using Newtonsoft.Json;

namespace XUnitTestStructureToOrganize
{
    public class UnitTestAuthenticationController
    {
        [Fact]
        public async Task RegisterUser_ReturnsJsonMessege_WhenUserAlreadyExists()
        {
            // Arrange
            string userEmail = "same_mail@test.com";
            User user = new User
            {
                Name = "TestName",
                Surname = "TestSurname",
                Email = userEmail,
                Password = "TestPassword"
            };
            User newUser = new User
            {
                Name = "AnotherName",
                Surname = "AnotherSurname",
                Email = userEmail,
                Password = "AnotherPassword"
            };
            var controller = new AuthenticationController();
            // Act
            var result = controller.Register(newUser);
            // Assert
            Assert.Same(result, JsonConvert.SerializeObject("A user with this Email already exists!"));
        }
    }
}
