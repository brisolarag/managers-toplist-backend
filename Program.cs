using Microsoft.EntityFrameworkCore;
using managers_back.src.context;
using managers_back.src.managers.interfaces;
using managers_back.src.managers;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApiContext>(options => {
  options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
  if(builder.Environment.IsDevelopment()) {
    options.EnableSensitiveDataLogging().LogTo(Console.WriteLine);
  }
});


builder.Services.AddControllers().AddJsonOptions(options => {
  options.JsonSerializerOptions.ReferenceHandler =
      System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IManagerRepository, ManagerRepository>();
builder.Services.AddScoped<IManagerService, ManagerService>();

builder.Services.AddCors(options => {
  options.AddPolicy("Free", policy => {
    policy.AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod();
  });
});

var app = builder.Build();

app.UseCors("Free");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
