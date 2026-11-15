using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoIntegrador.Web.Models;
using ProjetoIntegrador.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace ProjetoIntegrador.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;

    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public async Task<IActionResult> Index(UsuarioViewModel usuario)
    {
        // Coloque o breakpoint aqui

        var RA = usuario.RA;
        var senha = usuario.senha;


        var usuarioEncontrado = await _context.Usuarios
            .FirstOrDefaultAsync(u => u.Ra == RA);
        if (usuarioEncontrado == null)
        {
            ModelState.AddModelError(string.Empty, "Usuário não encontrado.");
            return View(usuario);
        }

        var senhaEncontrada = await _context.Usuarios
            .FirstOrDefaultAsync(u => u.senha == senha);
        if (senhaEncontrada == null)
        {
            ModelState.AddModelError(string.Empty, "Senha incorreta.");
            return View(usuario);
        }
        if (usuarioEncontrado.Ra == RA && senhaEncontrada.senha == senha)
        {
            HttpContext.Session.SetString("RA", usuarioEncontrado.Ra);
            return RedirectToAction("Index", "Aluno");
        }
        return View();
    }
}
