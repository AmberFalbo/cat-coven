// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.KittenCharmSpells;
using CatCoven.KittenCharmSpells.Data;
using Microsoft.EntityFrameworkCore;
using ProtoBuf.Grpc.Server;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("SpellsContextDatabase");
builder.Services.AddDbContext<SpellsDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddGrpc();
builder.Services.AddCodeFirstGrpc();

var app = builder.Build();

app.UseRouting();

app.MapGrpcService<KittenCharmSpellsService>();
app.MapGet("/", () => "Grpc call required");

app.Run();