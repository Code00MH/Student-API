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

//para cria��o do nosso endpoint, prossiga com app.map (neste caso, � o GET)
//app.MapGet("Hello World", () => "Hello World"); //perceba que passei o par�metro "Hello World", e retornei a fun��o "Hello World" com () =>

app.AddStudent(); 
app.Run();

