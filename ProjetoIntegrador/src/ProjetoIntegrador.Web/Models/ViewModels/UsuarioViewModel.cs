namespace ProjetoIntegrador.Web.Models;

using System.ComponentModel.DataAnnotations;

public class UsuarioViewModel
{
    public string username { get; set; } = string.Empty;
    public string senha { get; set; } = string.Empty;
}