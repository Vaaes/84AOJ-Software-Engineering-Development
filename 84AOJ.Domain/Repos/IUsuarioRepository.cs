using System;
using System.Threading.Tasks;
using _84AOJ.Domain.Entities;

namespace _84AOJ.Domain.Repos
{
    public interface IUsuarioRepository
    {
        bool VerificarUserExisteAsync(string email);
        Task<Usuario> AutenticaUserAsync(Login login);
    }
}
