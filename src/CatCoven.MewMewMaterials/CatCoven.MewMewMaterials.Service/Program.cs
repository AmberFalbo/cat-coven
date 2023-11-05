// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials;
using CatCoven.MewMewMaterials.Data;
using CatCoven.MewMewMaterials.Service;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("MaterialsContextDatabase");
builder.Services.AddDbContext<MaterialsDbContext>(options =>
    options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddGrpc();

builder.Services.AddTransient<IMewMewMaterialsProcessor, MewMewMaterialsProcessor>();
builder.Services.AddTransient<IMewMewMaterialsRepository, MewMewMaterialsRepository>();
builder.Services.AddTransient<IMewMewMaterialsRequestValidator, MewMewMaterialsRequestValidator>();

var app = builder.Build();

app.UseRouting();

app.MapGrpcService<MewMewMaterialsService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();