using System;
using System.Threading.Tasks;
using _84AOJ.Application.Interface;
using _84AOJ.Application.Request;
using _84AOJ.Domain.Entities;
using _84AOJ.Domain.Repos;

namespace _84AOJ.Application.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IUsuarioRepository _repository;


        #region Constructor
        public AuthenticationService(IUsuarioRepository repository)
        {
            _repository = repository;
        }
        #endregion

        #region Methods
        public bool VerificarUserExisteAsync(Login request)
        {
            return _repository.VerificarUserExisteAsync(request.Email);
        }


        public async Task<Usuario> AuthenticateAsync(Login request)
        {
            try
            {
                bool exists = _repository.VerificarUserExisteAsync(request.Email);

                if (!exists)
                    return await Task.FromResult<Usuario>(null);

                Usuario ret = await _repository.AutenticaUserAsync(request);

                return await Task.FromResult<Usuario>(ret);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
