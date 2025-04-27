using Intranet.Infra.Data.Interfaces;
using Intranet.Infra.Data.Contex;
using Intranet.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Intranet.Application.Interfaces;
using Intranet.Application.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("ApiConnection");

builder.Services.AddDbContext<ApiContext>(Options => {
                      Options.UseSqlServer(connectionString, dbOpts => dbOpts.MigrationsAssembly(typeof(Program).Assembly.FullName));
                   });
builder.Services.AddScoped<IAgendaRepository, AgendaRepository>();    
builder.Services.AddScoped<IAgendaService, AgendaService>();       

builder.Services.AddCors(
    options => {
        options.AddPolicy("cors",builder => {
            builder
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        });
    }
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers().AllowAnonymous();

app.Run();
