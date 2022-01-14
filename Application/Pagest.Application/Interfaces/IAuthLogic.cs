using Pagest.Application.Request;
using Pagest.Application.Responses;
using Pagest.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Pagest.Application.Interfaces
{
    public interface IAuthLogic
    {
        Task<Response<string>> RegisterAsync(RegisterModel model);
        Task<Response<AuthResponse>> LoginAsync(LoginModel model);
        Task<Response<AuthResponse>> RefreshTokenAsync(RefreshTokenRequest request);

    }
}
