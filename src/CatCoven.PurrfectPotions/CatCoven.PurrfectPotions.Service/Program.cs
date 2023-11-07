// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.PurrfectPotions;
using CatCoven.PurrfectPotions.Data;
using Microsoft.EntityFrameworkCore;
using ProtoBuf.Grpc.Server;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("PotionsContextDatabase");
builder.Services.AddDbContext<PotionsDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddGrpc();
builder.Services.AddCodeFirstGrpc();

var app = builder.Build();

app.UseRouting();

app.MapGrpcService<PurrfectPotionsService>();
app.MapGet("/", () => "Grpc call required");

app.Run();