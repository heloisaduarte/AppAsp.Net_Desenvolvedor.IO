using DemoVS;
using Serilog;

//Configura��o Builder
var builder = WebApplication.CreateBuilder(args);

//Configura��o do Pipeline
builder.AddSerilog();

builder.Services.AddControllersWithViews();

//Middlewares

//Services

//Configura��o da App
var app = builder.Build();

app.UseLogTempo();

//Configura��o de Comportamentos da App

app.MapGet("/", () => "Hello World!");

app.MapGet("/teste", () => 
{
    Thread.Sleep(1500);
    return "Teste 2";
});

app.Run();
