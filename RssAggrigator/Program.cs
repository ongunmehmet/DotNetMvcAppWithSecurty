using FastEndpoints;
using Microsoft.EntityFrameworkCore;
using RssAggrigator.Db;
using FastEndpoints.Security;

var bld = WebApplication.CreateBuilder();
bld.Services.AddDbContext<Context>(options => {
    options.UseNpgsql("User ID=postgres; Password=postgres; Database=ytRss2; Server=localhost; Port=5432; Include Error Detail=true;");
});
bld.Services.AddAuthenticationJwtBearer(x => x.SigningKey = bld.Configuration["JwtSecret"]) ;
bld.Services.AddAuthorization();


var app = bld.Build();
app.UseFastEndpoints();
app.Run();