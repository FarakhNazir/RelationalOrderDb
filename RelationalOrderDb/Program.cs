using Microsoft.EntityFrameworkCore;
using RelationalOrderDb.Models;
using RelationalOrderDb.Services;
using RelationalOrderDb.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RelationalOrderDb.DTO;
using Microsoft.AspNetCore.Mvc;
using RelationalOrderDb.Repositroy;
using RelationalOrderDb.Controllers;
using RelationalOrderDb.Repositroy.Abstract;
using RelationalOrderDb.CustomMiddlewareService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RelationalOrderDb.DTO.Responce;
using System.IdentityModel.Tokens.Jwt;
using System.IdentityModel.Tokens;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.Text;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<CustomMiddleware>();
builder.Services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<OrderSimpleContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionStringOrder")));
//builder.Services.AddTransient<ICustomerServices , CustomerServices>();
//builder.Services.AddScoped<ICustomerServices, CustomerServices>();

//Services Registration
builder.Services.AddTransient<ICustomerServices, CustomerServices>();
builder.Services.AddTransient<IOrderServices, OrderServices>();
builder.Services.AddTransient<IProductServices, ProductServices>();
builder.Services.AddTransient<ISupplierServices, SupplierServices>();

//Repository Registration
builder.Services.AddTransient<ICustomerRepository, CustomeRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();


builder.Services.AddSingleton<IJwtAuthentication, JwtAuthenticationServices>();

builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer( o =>
{
    o.SaveToken = true;
o.TokenValidationParameters = new TokenValidationParameters
{
    ValidIssuer = builder.Configuration["Jwt:Issuer"],
    ValidAudience = builder.Configuration["Jwt:Audience"],
    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),

    ValidateIssuer = false,
    ValidateAudience = false,
    ValidateLifetime = true,
    ValidateIssuerSigningKey = true
};
    
});

builder.Services.AddAuthorization();
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
// app.UseEndpoints(endpoints =>
// 	{
// 	    endpoints.MapControllers();
// 	});
app.Run();
// app.Use(async (context , next) =>
// {
//   await context.Response.WriteAsync("Middleware 1 \n");
//   await next();
//   await context.Response.WriteAsync("Middleware after 1 \n");
// });
// app.Map("/farrukh", customeocde);

// void customeocde(IApplicationBuilder app)
// {

// app.Use(async (context , next) =>
// {
//   await context.Response.WriteAsync("Middleware maping 2 \n");
//   await next();
//   await context.Response.WriteAsync("Middleware maping after 2 \n");
// });
// }
// app.Run(async context =>
// {
//     await context.Response.WriteAsync("Midddle ware Run\n.");
// });




