using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RssAggrigator.Dto;
using FastEndpoints;
using RssAggrigator.Services;

namespace RssAggrigator.Features
{
    public class LoginEdnpoint : Endpoint <LoginRequest,LoginResponse>
    {
        private readonly ILoginServices _loginServices;

        public LoginEdnpoint(ILoginServices loginServices)
        {
            _loginServices = loginServices;
        }

        public override void Configure()
         {
            Post("auth/login");
            AllowAnonymous();
        }

        public override Task<LoginResponse> ExecuteAsync(LoginRequest req, CancellationToken ct)
        {
            return base.ExecuteAsync(req, ct);
        }
    }
}