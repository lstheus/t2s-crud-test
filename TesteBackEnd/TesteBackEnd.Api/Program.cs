using FluentValidation;
using FluentValidation.AspNetCore;
using TesteBackEnd.Application.Interfaces;
using TesteBackEnd.Application.Mapper;
using TesteBackEnd.Application.Services;
using TesteBackEnd.Application.Validations;
using TesteBackEnd.Core.Interfaces;
using TesteBackEnd.Infra.Context;
using TesteBackEnd.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c => c.ResolveConflictingActions(c => c.FirstOrDefault()));
builder.Services.AddDbContext<TesteContext>();

builder.Services.AddScoped<IConteinerService, ConteinerService>();
builder.Services.AddScoped<IClienteService, ClienteService>();
builder.Services.AddScoped<IMovimentacaoService, MovimentacaoService>();
builder.Services.AddScoped<IRelatorioService, RelatorioService>();

builder.Services.AddScoped<IConteinerRepository, ConteinerRepository>();
builder.Services.AddScoped<IClienteRepository, ClienteRepository>();
builder.Services.AddScoped<IMovimentacaoRepository, MovimentacaoRepository>();
builder.Services.AddScoped<IRelatorioRepository, RelatorioRepository>();

builder.Services.AddAutoMapper(typeof(ClienteProfile));
builder.Services.AddAutoMapper(typeof(ConteinerProfile));
builder.Services.AddAutoMapper(typeof(MovimentacaoProfile));

builder.Services.AddValidatorsFromAssemblyContaining(typeof(ClienteValidation)).AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining(typeof(ConteinerValidation)).AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssemblyContaining(typeof(MovimentacaoValidation)).AddFluentValidationAutoValidation();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(c => c.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
