using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Service;
using Service.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var myCors = "InvestimentoCORS";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: myCors,
        policy =>
        {
            policy.WithOrigins("http://localhost:5183")
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
});

builder.Services.AddControllers();

var key = Encoding.ASCII.GetBytes(builder.Configuration.GetValue("TokenSecret", "#"));
var JwtOptions = new JwtBearerOptions()
{
    TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuerSigningKey = true,
        IssuerSigningKey = new SymmetricSecurityKey(key),
        ValidateIssuer = false,
        ValidateAudience = false
    }
};

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
        builder.Configuration.Bind("JwtSettings", JwtOptions)
    );

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

// Add services to the container.
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ITipoInvestimentoService, TipoInvestimentoService>();
builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddSingleton<TokenService>();

builder.Services.AddDbContext<InvestimentoDbContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("InvestimentoDb")
    ));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseCors(myCors);
}

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();

