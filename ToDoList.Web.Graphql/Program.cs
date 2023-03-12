using Microsoft.EntityFrameworkCore;
using ToDoList.DataAccess;
using ToDoList.DataAccess.Repositories;
using ToDoList.DataAccess.Schema.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ToDoListContext>(options => options.UseSqlServer(
    builder.Configuration.GetConnectionString("DbConString")).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking)
, ServiceLifetime.Transient);
builder.Services.AddTransient(typeof(UserRepository));
builder.Services.AddTransient(typeof(ToDoRepository));
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();


var app = builder.Build();

app.MapGraphQL("/todolist");

app.Run();
