using System;
using System.ComponentModel.DataAnnotations;

namespace _84AOJ.Application.Request
{
    public class RefreshTokenRequest
    {
        public RefreshTokenRequest(string token) => Token = token;

        [Required]
        public string Token { get; }
    }
}
