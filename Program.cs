using Divisas.Services;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<IMongoClient>((sp) => {
    return new MongoClient("mongodb+srv://namedRoger-Contador:DyTHsT5R4qFmZZGl@cluster0.flosazw.mongodb.net/?retryWrites=true&w=majority");
});

builder.Services.AddScoped<IMovimientoService, MovimientoService>();
builder.Services.AddScoped<IBitacoraService, BitacoraService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(op => op.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());

app.UseAuthorization();

app.MapControllers();

app.Run();
