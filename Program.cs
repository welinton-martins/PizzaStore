using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
// builder.Services.AddCors(options => {});

// builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Todo API", Description = "Keep track of you tasks", Version = "v1" });
}); 
var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Todo API V1");
    });
}

// end of if (app.Environment.IsDevelopment()) block
// app.UseCors("some unique string");
app.MapGet("/", () => "Hello World!");

app.Run();
