using Microsoft.EntityFrameworkCore;
using ToDoList.DataAccess;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ToDoListContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DbConString")).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
);
builder.Services
    .AddGraphQLServer();


var app = builder.Build();

app.MapGraphQL("/todolist");

app.Run();
