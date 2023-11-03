// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.KittenCharmSpells;
using CatCoven.KittenCharmSpells.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("SpellsContextDatabase");
builder.Services.AddDbContext<SpellsDbContext>(options =>
    options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<KittenCharmSpellsService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();