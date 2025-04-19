using FastEndpoints;
using Microsoft.EntityFrameworkCore;
using RssAggrigator.Db;
using FastEndpoints.Security;
using FastEndpoints.Swagger;
using RssAggrigator.Services;

var bld = WebApplication.CreateBuilder();
bld.Services.AddDbContext<Context>(options => {
    options.UseNpgsql("User ID=postgres; Password=postgres; Database=ytRss2; Server=localhost; Port=5432; Include Error Detail=true;");
});
bld.Services.AddAuthenticationJwtBearer(x => x.SigningKey = bld.Configuration["JwtSecret"]) ;
bld.Services.AddAuthorization();
bld.Services.AddFastEndpoints();
bld.Services.AddSwaggerDocument();
bld.Services.AddEndpointsApiExplorer();
bld.Services.AddScoped<IAuthServices, AuthService>();
bld.Services.AddScoped<ILoginServices, LoginService>();

var app = bld.Build();
app.UseFastEndpoints();
app.UseAuthentication();
app.UseAuthorization();
app.UseSwaggerGen();
app.Run();