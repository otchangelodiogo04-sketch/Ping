
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR();
builder.Services.AddDbContext<AppDb>(o=>o.UseSqlite("Data Source=ping.db"));
builder.Services.AddControllers();
var app = builder.Build();
app.MapHub<ChatHub>("/chat");
app.MapControllers();
app.Run();
