using System;
using System.Collections.Generic;
using System.Text;

namespace Pagest.Application.Responses
{
    public class AuthResponse
    {
        public string Token { get; set; }
        public Guid RefreshToken { get; set; }
    }
}
