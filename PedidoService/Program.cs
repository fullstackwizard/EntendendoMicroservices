var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // Adiciona suporte a Controllers

var app = builder.Build();

app.UseRouting();

app.MapControllers(); // Mapeia os controllers para rotas da API

app.Run();
