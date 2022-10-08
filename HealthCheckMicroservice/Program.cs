var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Add HealthChecks
builder.Services.AddHealthChecksUI()
                .AddInMemoryStorage();

var app = builder.Build();

// Add path for endpoints
app.MapHealthChecksUI();

app.MapControllers();

app.Run();
