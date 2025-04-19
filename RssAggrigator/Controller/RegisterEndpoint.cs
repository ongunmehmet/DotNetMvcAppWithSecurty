using FastEndpoints;
using RssAggrigator.Db;
using RssAggrigator.Dto;
using RssAggrigator.Entity;
using RssAggrigator.Services;

namespace RssAggrigator.Features
{
    public class RegisterEndpoint : Endpoint<RegisterRequest ,RegisterResponse>
    
    {
        private readonly IAuthServices _authService;
         public RegisterEndpoint(IAuthServices authService)
        {
            _authService = authService;
        }

        public override void Configure()
        {
            Post("auth/register");
            AllowAnonymous();
        }
          public override async Task<RegisterResponse> ExecuteAsync(RegisterRequest req, CancellationToken ct)
        {
            return await _authService.RegisterAsync(req);
        }
    }
}