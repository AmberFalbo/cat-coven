// ------------------------------------
// Cat Coven API
// ------------------------------------

using CatCoven.MewMewMaterials;
using CatCoven.MewMewMaterials.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("MaterialsContextDatabase");
builder.Services.AddDbContext<MaterialsDbContext>(options =>
    options.UseSqlServer(connectionString));

// Add services to the container.
builder.Services.AddGrpc();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<MewMewMaterialsService>();
app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();