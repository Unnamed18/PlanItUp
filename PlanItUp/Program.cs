using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using PlanItUp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//SERVICIO DE BASE DE DATOS
builder.Services.AddDbContext<AppDbContext>(
    op => op.UseSqlServer(builder.Configuration.GetConnectionString("conexion"))
   );

//SERVICIO DE AUTORIZACIÓN
builder.Services.AddAuthorization(op =>
{
    op.AddPolicy("RequireAdminOrClienteConsumOrClientePrest", policy =>
    policy.RequireRole("Administrador", "Cliente consumidor", "Cliente prestador"));
}); 

//SERVICIO DE AUTENTICACIÓN
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(op =>
{
    op.Cookie.HttpOnly = true;
    op.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    op.LoginPath = "/Account/Login";
    op.AccessDeniedPath = "/Account/AccessDenied";
});

//CONFIGURAR SERVICIOS A UTILIZAR



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication(); //AUTENTICO EL USUARIO
app.UseAuthorization();  //AUTORIZO AL USUARIO

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();