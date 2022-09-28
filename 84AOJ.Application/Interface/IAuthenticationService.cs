namespace _84AOJ.Application.Interface
{
    using System.Threading.Tasks;
    using _84AOJ.Application.Request;
    using _84AOJ.Domain.Entities;
    using _84AOJ.Shared.Interface;


    public interface IAuthenticationService : IAppService
    {
        Task<Usuario> AuthenticateAsync(Login request);
        bool VerificarUserExisteAsync(Login request);
    }
}
