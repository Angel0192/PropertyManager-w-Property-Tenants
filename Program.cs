using Microsoft.EntityFrameworkCore;
using PropertyManager.Models; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllersWithViews();

builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();


app.MapStaticAssets();
app.MapControllerRoute(name: "default", pattern: "{controller=Properties}/{action=Index}/{id?}")
   .WithStaticAssets();

app.Run();
