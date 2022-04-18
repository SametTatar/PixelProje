using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using PixelPlus.Core;
using PixelPlus.Core.Absctract;
using PixelPlus.Core.Concrete;
using PixelPlus.DAL;
using PixelPlus.UOW;
using Microsoft.Identity.Web;
using PixelPlus.Core.PixelPlus.DTO;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<Context>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Baglanti")));
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IAboneRepos, AboneRepos>();
builder.Services.AddScoped<IFaturaRepos, FaturaRepos>();
builder.Services.AddScoped<AboneLists>();
builder.Services.AddScoped<AboneKapatma>();
builder.Services.AddScoped<AboneOlustur>();
builder.Services.AddScoped<FaturaOdeme>();

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApi(builder.Configuration.GetSection("AzureAd"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
