using Demo02.Components;
using Demo02.Data;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
//add db context
builder.Services.AddDbContext<QLSPDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

//Them doan nay de dung swagger va controller
app.UseStaticFiles();
app.UseRouting();
app.UseAntiforgery();
app.UseSwagger();
app.UseSwaggerUI();
app.MapControllers();


app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
