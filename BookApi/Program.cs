var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger(options => 
{
    options.SerializeAsV2 = true;
});

app.UseSwaggerUI();

app.MapControllers(); 

app.Run();