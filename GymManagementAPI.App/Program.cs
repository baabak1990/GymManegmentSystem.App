using GymManagmentSystem.Infrastructurs.ServicesRegistration;
using GymManagmentSystem.Presistance.ServicesRegistration;
using GymManegmentApplication.ServicesRegistration;
using Microsoft.AspNetCore.Cors.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region IoC

builder.Services.persistenceServiceCollection(builder.Configuration);
builder.Services.ApplicationServices();
builder.Services.RegisterServiceCollection(builder.Configuration);

#endregion

builder.Services.AddCors(o =>
{
    o.AddPolicy("CoresPolicy",
        builder => builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("CoresPolicy");
app.MapControllers();

app.Run();
