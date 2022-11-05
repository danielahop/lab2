using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Hopirtean_Daniela_Lab3.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Hopirtean_Daniela_Lab3Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Hopirtean_Daniela_Lab3Context") ?? throw new InvalidOperationException("Connection string 'Hopirtean_Daniela_Lab3Context' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
