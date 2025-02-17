using crudAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
// este if verifica o ambiente de desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//para criação do nosso endpoint, prossiga com app.map (neste caso, é o GET)
//app.MapGet("Hello World", () => "Hello World"); //perceba que passei o parâmetro "Hello World", e retornei a função "Hello World" com () =>

app.AddStudent(); 
app.Run();

