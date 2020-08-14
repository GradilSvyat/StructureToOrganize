using System;
using System.Resources;
using System.Threading.Tasks;
using Xunit;
using StructureToOrganize.Controllers;
using System.Web.Mvc;

namespace XUnitTestStructureToOrganize
{
    public class UnitTestAuthenticationController
    {
        [Fact]
        public async Task RegisterUser_ReturnsJsonMessege_WhenUserAlreadyExists()
        {
            // Arrange
            string userEmail = "same_mail@test.com";
            User user = new User(Name = "TestName",
                                Surname = "TestSurname",
                                Email = userEmail,
                                Password = "TestPassword");
            User newUser = new User(Name = "AnotherName",
                                Surname = "AnotherSurname",
                                Email = userEmail,
                                Password = "AnotherPassword");

            // Act
            var result = Register(newUser);
            // Assert
            Assert.Same(result, Controller.Json("A user with this Email already exists!"));
        }
    }
}
