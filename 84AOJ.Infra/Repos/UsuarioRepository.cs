using System;
using System.Threading.Tasks;
using _84AOJ.Domain.Entities;
using _84AOJ.Domain.Repos;

namespace _84AOJ.Infra.Repos
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public UsuarioRepository()
        {
        }

        public bool VerificarUserExisteAsync(string email)
        {

            Usuario user = new Usuario()
            {
                Email = "pedro@gmail.com"
            };


            if (user.Email != email)
                return false;


            return true;
        }

        public Task<Usuario> AutenticaUserAsync(Login login)
        {
            try
            {
                Usuario user = new Usuario()
                {
                    Nome = "Pedro",
                    Email = "pedro@gmail.com",
                    HashSenha = "Mudar@123"
                };

                if(user.Email == login.Email && user.HashSenha == login.Password)
                    return Task.FromResult(user);

                return Task.FromResult<Usuario>(null);

            }
            catch (Exception ex)
            {
                throw ex;
                
            }

        }
    }
}
