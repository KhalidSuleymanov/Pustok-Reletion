using HomeTaskPustokReletion.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PustokDbContext>(opt =>
opt.UseSqlServer("Server = DESKTOP-AF9EOHB\\SQLEXPRESS; Database = Pustok; Integrated Security = true")
);

var app = builder.Build();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );


app.UseStaticFiles();

app.Run();
