namespace ProjetoIntegrador.Web.Models;

using System.ComponentModel.DataAnnotations;

public class EditarAlunoViewModel
{
    public string nome { get; set; } = string.Empty;
    public string senha { get; set; } = string.Empty;
    public string RA { get; set; } = string.Empty;
    public string cpf { get; set; } = string.Empty;
    public string telefone { get; set; } = string.Empty;
    public string endereco { get; set; } = string.Empty;
    public string tipo_usuario { get; set; } = string.Empty;
}   