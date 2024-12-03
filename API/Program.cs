using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Sqlite;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
// builder.Services.AddSwaggerGen();

// builder.Services.AddDbContext<StoreContext>(options =>
//      options.UseSqlite(builder.Configuration.GetConnectionString("SQLiteConnection")));
// builder.Services.AddScoped<StoreContext>();


builder.Services.AddSwaggerGen();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    
    app.UseSwagger();
    app.UseSwaggerUI();
}


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();