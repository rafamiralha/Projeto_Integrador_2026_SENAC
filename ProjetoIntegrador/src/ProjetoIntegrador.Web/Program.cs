// Supabase
using Microsoft.EntityFrameworkCore;
using ProjetoIntegrador.Web.Data;
// Supabase

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Supabase
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("Supabase")
    )
);
// Supabase

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


// Teste Supabase
app.MapGet("/teste-conexao", async (ApplicationDbContext db) =>
{
    var conectado = await db.Database.CanConnectAsync();

    if (conectado)
        return Results.Ok("Conexão com Supabase!");

    return Results.Problem("Não foi possível.");
});

app.MapGet("/teste", () => "Minha rota está funcionando!");

app.Run();