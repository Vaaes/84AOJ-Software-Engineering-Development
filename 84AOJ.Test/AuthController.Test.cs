using System.Threading.Tasks;
using _84AOJ.Api.Controllers;
using _84AOJ.Application.Interface;
using _84AOJ.Domain.Entities;
using _84AOJ.Domain.Repos;
using _84AOJ.Infra.Repos;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace _84AOJ.Test
{
    [TestClass]
    public class AuthTestController
    {
        private readonly Mock<IAuthenticationService> _mockService;
        private readonly AuthController _controller;

        public AuthTestController()
        {
            _mockService = new Mock<IAuthenticationService>();
            _controller = new AuthController(_mockService.Object);
        }

        [TestMethod]
        public void Auth_Endpoint_BadRequest()
        {

            // Act
            Mock<IAuthenticationService> mock = new Mock<IAuthenticationService>();

            var request = new Login()
            {
                Email = "pedro@gmail.com",
                Password = "Mudar@123"
            };

            // Arrange
            var response = _controller.Authenticate(request);

            // Assert
            Assert.IsTrue(true);
            Assert.IsNotNull(response);

        }



        [TestMethod]
        public void VerificarUserExiste_Success()
        {
            // Act
            var mock = new Mock<IUsuarioRepository>();


            // Arrange
            mock.Setup(p => p.VerificarUserExisteAsync("pedro@gmail.com")).Returns(true);

            var repository = new UsuarioRepository();
            bool result = repository.VerificarUserExisteAsync("pedro@gmail.com");

            // Assert
            Assert.IsTrue(result);

        }

        [TestMethod]
        public void VerificarUserExiste_Fail()
        {
            // Act
            var mock = new Mock<IUsuarioRepository>();


            // Arrange
            mock.Setup(p => p.VerificarUserExisteAsync("")).Returns(false);

            var repository = new UsuarioRepository();
            bool result = repository.VerificarUserExisteAsync("");

            // Assert
            Assert.IsFalse(result);

        }
    }
}
