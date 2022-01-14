using System;
using System.Collections.Generic;
using System.Text;

namespace Pagest.Application.Request
{
    public class RefreshTokenRequest
    {
        public string Token { get; set; }
        public Guid RefreshToken { get; set; }
    }
}
