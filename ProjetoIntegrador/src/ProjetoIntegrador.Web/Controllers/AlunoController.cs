using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ProjetoIntegrador.Web.Models;
using ProjetoIntegrador.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace ProjetoIntegrador.Web.Controllers;

public class AlunoController : Controller
{
    private readonly ILogger<AlunoController> _logger;
    private readonly ApplicationDbContext _context;

    public AlunoController(ILogger<AlunoController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task <IActionResult> Index(EditarAlunoViewModel aluno)
    {
        var RA = HttpContext.Session.GetString("RA");

    if (string.IsNullOrEmpty(RA))
    {
        return RedirectToAction("Index", "Home");
    }

    var usuarioEncontrado = await _context.Usuarios
        .FirstOrDefaultAsync(u => u.Ra == RA);
        if (usuarioEncontrado != null)
{
    aluno.nome = usuarioEncontrado.Nome;
    aluno.RA = usuarioEncontrado.Ra;
    aluno.cpf = usuarioEncontrado.Cpf;
    aluno.senha = usuarioEncontrado.senha;
    aluno.endereco = usuarioEncontrado.Endereco;
    aluno.telefone = usuarioEncontrado.Telefone;
    aluno.tipo_usuario = usuarioEncontrado.TipoUsuario;
}
            
    //     var aluno = new UsuarioViewModel
    // {
    //     RA = "123456",
    //     Nome = "João da Silva",
    //     Email = "joao@email.com",
    //     Curso = "Análise e Desenvolvimento de Sistemas",
    //     Semestre = "3º Semestre",
    //     Periodo = "Noturno",
    //     Situacao = "Matriculado"
    // };

    return View("Index", aluno);
    }

[HttpPost]
[ValidateAntiForgeryToken]
public async Task<IActionResult> Salvar(EditarAlunoViewModel aluno)
{
    var usuarioEncontrado = await _context.Usuarios
        .FirstOrDefaultAsync(a => a.Ra == aluno.RA);

    if (usuarioEncontrado != null)
    {
        usuarioEncontrado.Nome = aluno.nome;
        usuarioEncontrado.Endereco = aluno.endereco;
        usuarioEncontrado.Telefone = aluno.telefone;

        await _context.SaveChangesAsync();

        TempData["Mensagem"] = "Dados alterados com sucesso!";
    }
    else
    {
        TempData["Erro"] = "Não foi possível localizar o aluno.";
    }

    return RedirectToAction("Index", "Aluno");
}

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}