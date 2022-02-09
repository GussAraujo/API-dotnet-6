// criando servidor WEB - rodando na porta 7051
using MiniTodo.Data;

var builder = WebApplication.CreateBuilder(args);

// Conexao com o Banco
builder.Services.AddDbContext<AppDbContext>();

var app = builder.Build();

app.MapGet("/v1/todos", (AppDbContext context) =>
{
    var todos = context.Todos.ToList();
    return Results.Ok(todos);
});

app.Run();