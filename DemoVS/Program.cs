using DemoVS;
using Serilog;

//Configuração Builder
var builder = WebApplication.CreateBuilder(args);

//Configuração do Pipeline
builder.AddSerilog();

builder.Services.AddControllersWithViews();

//Middlewares

//Services

//Configuração da App
var app = builder.Build();

app.UseLogTempo();

//Configuração de Comportamentos da App

app.MapGet("/", () => "Hello World!");

app.MapGet("/teste", () => 
{
    Thread.Sleep(1500);
    return "Teste 2";
});

app.Run();
