using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using VeterinariaPichichus.Context;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor de dependencias.
builder.Services.AddControllersWithViews(); // Habilita los controladores y vistas (MVC)
builder.Services.AddDbContext<DuenioContext>(); // Habilita Entity Framework
// Configuración de Entity Framework (opcional)
// builder.Services.AddDbContext<AppDbContext>(options =>
//     options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configuración del pipeline de la aplicación.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage(); // Muestra páginas detalladas de error  en desarrollo
}
else
{
    app.UseExceptionHandler("/Home/Error"); // Página de error para producción
    app.UseHsts(); // Seguridad HTTPS
}

app.UseHttpsRedirection(); // Redirecciona a HTTPS
app.UseStaticFiles(); // Habilita archivos estáticos (CSS, JavaScript, imágenes, etc.)

app.UseRouting(); // Habilita la generación de rutas

app.UseAuthorization(); // Middleware de autorización

// Configuración de rutas.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Ruta por defecto

app.Run();
