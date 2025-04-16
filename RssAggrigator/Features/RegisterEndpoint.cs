using FastEndpoints;
using RssAggrigator.Db;
using RssAggrigator.Dto;
using RssAggrigator.Entity;

namespace RssAggrigator.Features
{
    public class RegisterEndpoint : Endpoint<RegisterRequest ,RegisterResponse>
    
    {
        private readonly Context context;
        public RegisterEndpoint(Context context){
            this.context= context;

        }

        public override void Configure()
        {
            Post("auth/register");
            AllowAnonymous();
            base.Configure();
        }
        public override async Task<RegisterResponse> ExecuteAsync(RegisterRequest req, CancellationToken ct)
        {
            var newUser= new AppUser{
                Email = req.Email, 
                Password= req.Password,
                Role = req.Role};
            context.Users.Add(newUser);
            await context.SaveChangesAsync();

            var res= new RegisterResponse{
                Id = newUser.Id,
                Email = newUser.Email

            };

            return res;
        
        }
    }
}