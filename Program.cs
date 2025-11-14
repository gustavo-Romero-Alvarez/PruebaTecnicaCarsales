using PruebaTecnicaCarsalesBack.Clients;
using PruebaTecnicaCarsalesBack.Configuration;
using PruebaTecnicaCarsalesBack.Interfaces;
using PruebaTecnicaCarsalesBack.Services;

var builder = WebApplication.CreateBuilder(args);

// CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngular",
        policy =>
        {
            policy.WithOrigins("http://localhost:4200")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

builder.Services.Configure<RickAndMortySettings>(
    builder.Configuration.GetSection("RickAndMortyApi")
);

builder.Services.AddHttpClient<IRickAndMortyClient, RickAndMortyClient>();
builder.Services.AddScoped<IEpisodeService, EpisodeService>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors("AllowAngular");

app.UseHttpsRedirection();

app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

app.Run();
