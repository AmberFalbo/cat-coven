// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials.Data;
using CatCoven.MewMewMaterials.Service;
using Microsoft.EntityFrameworkCore;
using ProtoBuf.Grpc.Server;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("MaterialsContextDatabase");
builder.Services.AddDbContext<MaterialsDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddGrpc();
builder.Services.AddCodeFirstGrpc();

builder.Services.AddTransient<IMewMewMaterialsProcessor, MewMewMaterialsProcessor>();
builder.Services.AddTransient<IMewMewMaterialsRepository, MewMewMaterialsRepository>();
builder.Services.AddTransient<IMewMewMaterialsRequestValidator, MewMewMaterialsRequestValidator>();

var app = builder.Build();

app.UseRouting();

app.MapGrpcService<MewMewMaterialsService>();
app.MapGet("/", () => "Grpc call required");

app.Run();